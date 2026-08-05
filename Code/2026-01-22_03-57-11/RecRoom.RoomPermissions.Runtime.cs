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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B99590", Offset = "0x8B97D90", VA = "0x188B99590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BA3EA0", Offset = "0x8BA26A0", VA = "0x188BA3EA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
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
	public delegate void OnRoomRoleUpdated(MNBQIABPYXS player);
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
	public interface JGTEPHNDKZY
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CQRNETVFVJR
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UMMOYMOQLSX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool EZGVEKUSTQL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool FNWJNLYAQFU
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool NCABMBDWLYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool ZIDRIFXCZQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool MYKAFKFLMRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class NNQPNKNXWBX
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
		public static readonly Guid ZYIJYLACPVB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid UKNLOCTKPPG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid LEJPUFQEMPN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid FXXNAJPKUIP;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid DFAOEFFEPOO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid HATYHSCPXHT;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly YHVCXFFLNIY<AccountRoleType, Guid> USPIQALZVAU;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> APXLSAFGISB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B98F50", Offset = "0x8B97750", VA = "0x188B98F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B99040", Offset = "0x8B97840", VA = "0x188B99040")]
		public static AccountRoleType QIHDHZONMPA(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B990D0", Offset = "0x8B978D0", VA = "0x188B990D0")]
		public static Guid RZWVUTTDZTU(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B99170", Offset = "0x8B97970", VA = "0x188B99170")]
		public static bool TCVLKJCEWML(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B99200", Offset = "0x8B97A00", VA = "0x188B99200")]
		public static bool WOGTUWHBFEP(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B98FC0", Offset = "0x8B977C0", VA = "0x188B98FC0")]
		public static AccountRoleType NFVHNJLAHTS(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B98EA0", Offset = "0x8B976A0", VA = "0x188B98EA0")]
		public static DEPRECATED_RoomRoleId JJYPPSXQWMD(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B99000", Offset = "0x8B97800", VA = "0x188B99000")]
		internal static AccountRoleType PKMMYICPZGW(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IBQEKKDJZBI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		MNBQIABPYXS QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance NSAOYIYELPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO XPEUKANLTEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> VTGBGEOLMRJ;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action RHPJTPEEOLH;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType MIPQVDZVAKL(MNBQIABPYXS a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> OHLTYBVVHHE(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task AWPLJWMRBPS(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task NTCOIKGVWHS(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<MNBQIABPYXS> TAZQMYGRJBD();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class MTBYUJAHUAY
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B98E40", Offset = "0x8B97640", VA = "0x188B98E40")]
		public static AccountRoleType OZAIJZQKGTW(this IBQEKKDJZBI a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface BNOTNEPADVS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		RJMLZBVLYXB QBIKVQYFXIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated QFXHRJFGPBL;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<OIPBJDWJDZD> WTYXBWFBBIT(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		OIPBJDWJDZD DZZYOQQLLMV(MNBQIABPYXS a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PZUPKFWUFQC(MNBQIABPYXS a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<OIPBJDWJDZD> KXSWENBDXRR(MNBQIABPYXS a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool INYFMDQMVVZ(MNBQIABPYXS a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		OIPBJDWJDZD FKAZIRSBOQS(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HJMDVPSBICC<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string VAHNWVOEFXY(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool HRHTZUWIUSK(MNBQIABPYXS a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface IASQMLQLWKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task LITRYGOLHYI(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NPZDRUJSIOH<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> ECQYCITTHFG;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? TXRDHRGKWNO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? DUAHQQKVSJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B99710", Offset = "0x8B97F10", VA = "0x188B99710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B99610", Offset = "0x8B97E10", VA = "0x188B99610")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B997E0", Offset = "0x8B97FE0", VA = "0x188B997E0")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool TLFQBOTRZUC(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> SPCMLSKTGAM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T ZBQGWKFCAQI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5AE3000", Offset = "0x5AE1800", VA = "0x185AE3000")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE38C0", Offset = "0x5AE20C0", VA = "0x185AE38C0", Slot = "4")]
		public override bool TLFQBOTRZUC(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE3F80", Offset = "0x5AE2780", VA = "0x185AE3F80")]
		public bool XQMVRQZVWSA(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4100", Offset = "0x5AE2900", VA = "0x185AE4100")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ZKJWIMBJQJX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> UXFIZAHLVUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> RBRCMGOBSFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly QWDGNRCLOWS OXYLRGIKQFM;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3C00", Offset = "0x8BA2400", VA = "0x188BA3C00")]
		public ZKJWIMBJQJX(QWDGNRCLOWS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3A00", Offset = "0x8BA2200", VA = "0x188BA3A00")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3C42780", Offset = "0x3C40F80", VA = "0x183C42780")]
		public bool BWEEOMUGYFE<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C43010", Offset = "0x3C41810", VA = "0x183C43010")]
		public (bool, a?) WDAQWQHPDGS<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3660", Offset = "0x8BA1E60", VA = "0x188BA3660")]
		public bool BWEEOMUGYFE(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3A70", Offset = "0x8BA2270", VA = "0x188BA3A70")]
		public (bool, object) WDAQWQHPDGS(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C42F30", Offset = "0x3C41730", VA = "0x183C42F30")]
		private void FFITIOFHNDH<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3740", Offset = "0x8BA1F40", VA = "0x188BA3740")]
		private Permission GITPBDMSUSD(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3810", Offset = "0x8BA2010", VA = "0x188BA3810")]
		public void OCAGLSXEKTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class JLOFOKWRBCQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string UCUOZKDHPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type HUKEDUYYZAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType JIRMZRWBLOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission XQWTWUZTMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet YZKCGNDZIUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue YGAXLGBXHZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission LTQGXRFJAQD;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B97090", Offset = "0x8B95890", VA = "0x188B97090")]
		public JLOFOKWRBCQ(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B97040", Offset = "0x8B95840", VA = "0x188B97040")]
		public object VQMITESWDGM(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3769680", Offset = "0x3767E80", VA = "0x183769680")]
		public void FFITIOFHNDH<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B96F90", Offset = "0x8B95790", VA = "0x188B96F90")]
		public void FFITIOFHNDH(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class SVLREAWGOQL<a> : JLOFOKWRBCQ where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class WSROETRUXZR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet RUDLOLTPGFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue CWBCKCGDKAO;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WSROETRUXZR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66B9F40", Offset = "0x66B8740", VA = "0x1866B9F40")]
			internal string MOXBJULNNJZ(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66B9980", Offset = "0x66B8180", VA = "0x1866B9980")]
			internal object MORUMNRQDYQ(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB8510", Offset = "0x5EB6D10", VA = "0x185EB8510")]
		public SVLREAWGOQL(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB7520", Offset = "0x5EB5D20", VA = "0x185EB7520")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB7780", Offset = "0x5EB5F80", VA = "0x185EB7780")]
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
	internal class QWDGNRCLOWS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class YDEZXGXGKBS : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static YDEZXGXGKBS QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BA3250", Offset = "0x8BA1A50", VA = "0x188BA3250", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BA33A0", Offset = "0x8BA1BA0", VA = "0x188BA33A0", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public YDEZXGXGKBS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class FIJFSHLKAAO : CNQKQSPMGJN<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B94F60", Offset = "0x8B93760", VA = "0x188B94F60", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8B95050", Offset = "0x8B93850", VA = "0x188B95050", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B95200", Offset = "0x8B93A00", VA = "0x188B95200")]
			public FIJFSHLKAAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly XGOAIRZJZTD MEDNAGBYMPH;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly FIJFSHLKAAO RXFAZTVANWO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<JLOFOKWRBCQ> EZHAWMXQVZN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> LBULKYSILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, JLOFOKWRBCQ> EMBUHVQRUVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B790", Offset = "0x8B99F90", VA = "0x188B9B790")]
		public QWDGNRCLOWS([Optional] IList<JLOFOKWRBCQ>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8B998E0", Offset = "0x8B980E0", VA = "0x188B998E0")]
		public JLOFOKWRBCQ EXCOYSLMHRB(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface RJMLZBVLYXB
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		OIPBJDWJDZD UEZUPSQNNYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class KMPUZBAYQIY : RJMLZBVLYXB
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static KMPUZBAYQIY FJXEZSJLRIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly IZINSWHTXKM VNFLIJNIINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<IZINSWHTXKM> FYTMZHHQACD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public OIPBJDWJDZD UEZUPSQNNYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B98210", Offset = "0x8B96A10", VA = "0x188B98210")]
		public KMPUZBAYQIY(IZINSWHTXKM a, IReadOnlyList<IZINSWHTXKM> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B97130", Offset = "0x8B95930", VA = "0x188B97130")]
		private static KMPUZBAYQIY KGBLWOEYYYH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class MLRGDHBXYWD
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> FDMCIZDUBOS;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B98310", Offset = "0x8B96B10", VA = "0x188B98310")]
		public static bool DIXGGTIJYRW(this MNBQIABPYXS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B983F0", Offset = "0x8B96BF0", VA = "0x188B983F0")]
		public static bool OTEDBXDPYOZ(this MNBQIABPYXS a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface MJXIKRSOVWK
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> SDOIQNKOVQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType IZJXPGULVXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface OIPBJDWJDZD : MJXIKRSOVWK, JGTEPHNDKZY, NPZDRUJSIOH<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string PUFBMXJILWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType XTEFSTHFIOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) FSLLEEFPUTW<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class IZINSWHTXKM : OIPBJDWJDZD, MJXIKRSOVWK, JGTEPHNDKZY, NPZDRUJSIOH<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly QWDGNRCLOWS QWDGNRCLOWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly ZKJWIMBJQJX YMQROTOOXYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? QWDCYLSDASA;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool YVFPYWOYDCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8B95420", Offset = "0x8B93C20", VA = "0x188B95420", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool TCPGZRMCDUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8B95A00", Offset = "0x8B94200", VA = "0x188B95A00", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool LFVTYGKWELJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8B96CD0", Offset = "0x8B954D0", VA = "0x188B96CD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool VWKFECEMMKC
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8B96840", Offset = "0x8B95040", VA = "0x188B96840", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool DAMJJHVZRTA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8B95870", Offset = "0x8B94070", VA = "0x188B95870", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool YAVWWGXHHQB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B95820", Offset = "0x8B94020", VA = "0x188B95820", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RPVIDMVSSLT
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8B967D0", Offset = "0x8B94FD0", VA = "0x188B967D0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType XTEFSTHFIOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAB0610", Offset = "0xAAEE10", VA = "0x180AB0610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x73DB770", Offset = "0x73D9F70", VA = "0x1873DB770", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string PUFBMXJILWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x73DB770", Offset = "0x73D9F70", VA = "0x1873DB770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool CDZRLEIBHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB046C0", Offset = "0xB02EC0", VA = "0x180B046C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB045B0", Offset = "0xB02DB0", VA = "0x180B045B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType IZJXPGULVXM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8B96D20", Offset = "0x8B95520", VA = "0x188B96D20", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> SDOIQNKOVQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B969B0", Offset = "0x8B951B0", VA = "0x188B969B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool SLEFUBHKZJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B95420", Offset = "0x8B93C20", VA = "0x188B95420", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool DFQYHEVFSRS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B95870", Offset = "0x8B94070", VA = "0x188B95870", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool OFFWPWTDPIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B95A00", Offset = "0x8B94200", VA = "0x188B95A00", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool KFBMHXBAKZX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B96CD0", Offset = "0x8B954D0", VA = "0x188B96CD0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool PYDNLJWXSWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B96840", Offset = "0x8B95040", VA = "0x188B96840", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool XPNKMMTCNTR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B95820", Offset = "0x8B94020", VA = "0x188B95820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool XTYRKMKNVFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8B967D0", Offset = "0x8B94FD0", VA = "0x188B967D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> ECQYCITTHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8B958C0", Offset = "0x8B940C0", VA = "0x188B958C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B96890", Offset = "0x8B95090", VA = "0x188B96890", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x37505F0", Offset = "0x374EDF0", VA = "0x1837505F0", Slot = "6")]
		public (bool, a?) FSLLEEFPUTW<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3750AC0", Offset = "0x374F2C0", VA = "0x183750AC0")]
		public IZINSWHTXKM VKTQUTXGMXK<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B96E30", Offset = "0x8B95630", VA = "0x188B96E30")]
		public IZINSWHTXKM(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B96F70", Offset = "0x8B95770", VA = "0x188B96F70")]
		public IZINSWHTXKM(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B96DE0", Offset = "0x8B955E0", VA = "0x188B96DE0")]
		public IZINSWHTXKM(IZINSWHTXKM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B96E50", Offset = "0x8B95650", VA = "0x188B96E50")]
		internal IZINSWHTXKM(AccountRoleType a, [Optional] string? b, [Optional] IZINSWHTXKM? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B96940", Offset = "0x8B95140", VA = "0x188B96940")]
		public static RolePermissionType RYMTSJRUZMG(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B96820", Offset = "0x8B95020", VA = "0x188B96820")]
		public void OCAGLSXEKTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B95B30", Offset = "0x8B94330", VA = "0x188B95B30")]
		internal IZINSWHTXKM KEJDIONIERK(IZINSWHTXKM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B95470", Offset = "0x8B93C70", VA = "0x188B95470")]
		internal IReadOnlyCollection<RolePermission> Copy(IZINSWHTXKM roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B95A50", Offset = "0x8B94250", VA = "0x188B95A50")]
		public bool GITMQXJNSWR(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B96A10", Offset = "0x8B95210", VA = "0x188B96A10")]
		public (bool, string) WRNNSAHUPMA(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B95E20", Offset = "0x8B94620", VA = "0x188B95E20")]
		internal void LGOAGIUGIUH(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B96B10", Offset = "0x8B95310", VA = "0x188B96B10")]
		public DDJDYJRQPZP XTVRBPTCHUB(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B95E70", Offset = "0x8B94670", VA = "0x188B95E70")]
		public void NQRDGIWBNUJ(DDJDYJRQPZP a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B95970", Offset = "0x8B94170", VA = "0x188B95970")]
		[CompilerGenerated]
		private void DRIZVDMZGBR(RolePermission a, ZEWXQOUGCEM b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class XYSPNQBLIOZ : IASQMLQLWKF, BNOTNEPADVS, IDisposable, WHNLGLIYXGI
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class VXXICVGINJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public IZINSWHTXKM ZVVFOHULCZV;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VXXICVGINJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8B9D410", Offset = "0x8B9BC10", VA = "0x188B9D410")]
			internal bool UFRXCEKYHMZ(IZINSWHTXKM a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class XQTSCXJHXWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType MEFCFQQYOGH;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XQTSCXJHXWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1C43D10", Offset = "0x1C42510", VA = "0x181C43D10")]
			internal bool KULEGLCOODP(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class GNSJUUVFLZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder OIXXWWLJYLF;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public GNSJUUVFLZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8B95240", Offset = "0x8B93A40", VA = "0x188B95240")]
			internal void QCELZDLIQSW(DDJDYJRQPZP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8B95320", Offset = "0x8B93B20", VA = "0x188B95320")]
			internal void QCJSWKFGAEF(DDJDYJRQPZP a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <>c__DisplayClass35_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PersistedRoomData roomData;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BUBGRJJTWPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<DDJDYJRQPZP, ZEWXQOUGCEM> MFSJYDQRVNL;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public BUBGRJJTWPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8B94ED0", Offset = "0x8B936D0", VA = "0x188B94ED0")]
			internal void QZLTKNVQUGH(DDJDYJRQPZP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8B94F00", Offset = "0x8B93700", VA = "0x188B94F00")]
			internal void QZRAHUPODRQ(DDJDYJRQPZP a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8B94F30", Offset = "0x8B93730", VA = "0x188B94F30")]
			internal void QZWHFBJLNCZ(DDJDYJRQPZP a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class ZFOIHMWHOTA<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public ZFOIHMWHOTA<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x3CD8AB0", Offset = "0x3CD72B0", VA = "0x183CD8AB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission ILFUIMEPYSE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType YLEOEUDRYUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool LRVGACZMPWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType YHYIGNTMOOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string RWDNOAYZQVA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public XYSPNQBLIOZ BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action NAJTJRCPRLD;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public ZFOIHMWHOTA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3E623B0", Offset = "0x3E60BB0", VA = "0x183E623B0")]
			[AsyncStateMachine(typeof(ZFOIHMWHOTA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void TARPODTQJFX()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct <>c__DisplayClass51_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public IReadOnlyList<RolePermissionDTO> newPermissionOverrides;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <CoOwnerMigrateLegacyProtobufToRecNet>d__53 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public IBQEKKDJZBI rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, IZINSWHTXKM> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public WTCYPBNJOYZ debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BAA0", Offset = "0x8B9A2A0", VA = "0x188B9BAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8B9C5A0", Offset = "0x8B9ADA0", VA = "0x188B9C5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private struct <LEGACY_DeserializeFrom>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public XYSPNQBLIOZ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private bool <isOffline>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8B9C600", Offset = "0x8B9AE00", VA = "0x188B9C600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8B9CC70", Offset = "0x8B9B470", VA = "0x188B9CC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly IBQEKKDJZBI TBKVUJLTURX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly KMPUZBAYQIY KLWQJEDMFQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly WTCYPBNJOYZ VXWXZITTUAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private GFMHWLVNTQB? MEQQBAVUAWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> HIBUYYBCVPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, IZINSWHTXKM> SHPHREJOARD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, IZINSWHTXKM> RQDBNFHFGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, IZINSWHTXKM> WSVQDQWIEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<IZINSWHTXKM> ROJVXKFJOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool ZVHOCHEGQNP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] OLNFXZAHTCZ;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public RJMLZBVLYXB QBIKVQYFXIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated QFXHRJFGPBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1320", Offset = "0x8B9FB20", VA = "0x188BA1320", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1A40", Offset = "0x8BA0240", VA = "0x188BA1A40", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA14E0", Offset = "0x8B9FCE0", VA = "0x188BA14E0")]
		[SLGIUIECCXF.Room]
		internal static void SLGIUIECCXF(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2FA0", Offset = "0x8BA17A0", VA = "0x188BA2FA0")]
		[UnityEngine.Scripting.Preserve]
		internal XYSPNQBLIOZ([Inject(null)] IBQEKKDJZBI roleDataProvider, [Inject(null)] KMPUZBAYQIY roleManagerDefaults, [Inject(null)] WTCYPBNJOYZ debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DC80", Offset = "0x8B9C480", VA = "0x188B9DC80", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2130", Offset = "0x8BA0930", VA = "0x188BA2130")]
		private void YZLCPXEZXPV(IEnumerable<IZINSWHTXKM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1230", Offset = "0x8B9FA30", VA = "0x188BA1230", Slot = "10")]
		public bool PZUPKFWUFQC(MNBQIABPYXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA14D0", Offset = "0x8B9FCD0", VA = "0x188BA14D0")]
		private void RHPJTPEEOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0220", Offset = "0x8B9EA20", VA = "0x188BA0220", Slot = "19")]
		public void NXHSBKKEULM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1D80", Offset = "0x8BA0580", VA = "0x188BA1D80", Slot = "8")]
		public IReadOnlyList<OIPBJDWJDZD> WTYXBWFBBIT(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DB20", Offset = "0x8B9C320", VA = "0x188B9DB20", Slot = "9")]
		public OIPBJDWJDZD DZZYOQQLLMV(MNBQIABPYXS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0150", Offset = "0x8B9E950", VA = "0x188BA0150")]
		private AccountRoleType NXAIVCBAQJZ(MNBQIABPYXS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E480", Offset = "0x8B9CC80", VA = "0x188B9E480", Slot = "12")]
		public bool INYFMDQMVVZ(MNBQIABPYXS a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E080", Offset = "0x8B9C880", VA = "0x188B9E080", Slot = "13")]
		public OIPBJDWJDZD FKAZIRSBOQS(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D7F0", Offset = "0x8B9BFF0", VA = "0x188B9D7F0")]
		private static bool DQFVTKZZJKX(VXMSSEALKDS a, AccountRoleType b, [Out] DDJDYJRQPZP? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EB40", Offset = "0x8B9D340", VA = "0x188B9EB40")]
		private static void JNOLKHZCLPZ(VXMSSEALKDS a, Action<DDJDYJRQPZP> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E8B0", Offset = "0x8B9D0B0", VA = "0x188B9E8B0")]
		private static void JNOLKHZCLPZ(VXMSSEALKDS a, Action<DDJDYJRQPZP> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D780", Offset = "0x8B9BF80", VA = "0x188B9D780")]
		private void DDPZCJGZOMG(MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F700", Offset = "0x8B9DF00", VA = "0x188B9F700", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task LITRYGOLHYI([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1E00", Offset = "0x8BA0600", VA = "0x188BA1E00")]
		private void XQESOLUVHNI(VXMSSEALKDS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DD80", Offset = "0x8B9C580", VA = "0x188B9DD80")]
		internal static string EZVEWGJEZLA(IBQEKKDJZBI a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IZINSWHTXKM> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0550", Offset = "0x8B9ED50", VA = "0x188BA0550")]
		private static void OXVFSUWFEWQ(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1690", Offset = "0x8B9FE90", VA = "0x188BA1690")]
		private static void UJXAPVCNMNZ(VXMSSEALKDS a, IReadOnlyDictionary<AccountRoleType, IZINSWHTXKM> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA13C0", Offset = "0x8B9FBC0", VA = "0x188BA13C0")]
		private static bool RFGZYYSJUFA(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B9FA30", Offset = "0x8B9E230", VA = "0x188B9FA30")]
		private static void MXNWVGIGHAX(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FC60", Offset = "0x3C1E460", VA = "0x183C1FC60", Slot = "14")]
		public bool HJMDVPSBICC<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA19D0", Offset = "0x8BA01D0", VA = "0x188BA19D0", Slot = "15")]
		public string VAHNWVOEFXY(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E260", Offset = "0x8B9CA60", VA = "0x188B9E260", Slot = "16")]
		public bool HRHTZUWIUSK(MNBQIABPYXS a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D6C0", Offset = "0x8B9BEC0", VA = "0x188B9D6C0", Slot = "18")]
		public bool CJRIQLFPFVU(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F820", Offset = "0x8B9E020", VA = "0x188B9F820")]
		private void MONMQTANOJW(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1300", Offset = "0x8B9FB00", VA = "0x188BA1300")]
		private bool PlayerHasRole(MNBQIABPYXS player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1AE0", Offset = "0x8BA02E0", VA = "0x188BA1AE0")]
		private IZINSWHTXKM WHGBBGNIGMC(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA29B0", Offset = "0x8BA11B0", VA = "0x188BA29B0")]
		internal AccountRoleType ZHWZIXWRKJY(MNBQIABPYXS a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E120", Offset = "0x8B9C920", VA = "0x188B9E120")]
		private void GRQBWEWCKUM(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F680", Offset = "0x8B9DE80", VA = "0x188B9F680", Slot = "11")]
		public IReadOnlyList<OIPBJDWJDZD> KXSWENBDXRR(MNBQIABPYXS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B9F680", Offset = "0x8B9DE80", VA = "0x188B9F680")]
		internal IReadOnlyList<IZINSWHTXKM> UNPILHFXBMC(MNBQIABPYXS a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2C30", Offset = "0x8BA1430", VA = "0x188BA2C30")]
		internal IReadOnlyList<IZINSWHTXKM> ZXDWXSBUEUY(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EF10", Offset = "0x8B9D710", VA = "0x188B9EF10")]
		private void KGOJDXJMVNR(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EC30", Offset = "0x8B9D430", VA = "0x188B9EC30")]
		private static bool JTEZKMLYJVP(IZINSWHTXKM a, IReadOnlyDictionary<AccountRoleType, IZINSWHTXKM> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA0410", Offset = "0x8B9EC10", VA = "0x188BA0410")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task OEAJJRPVAVT(IBQEKKDJZBI a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IZINSWHTXKM> c, WTCYPBNJOYZ d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D440", Offset = "0x8B9BC40", VA = "0x188B9D440")]
		[CompilerGenerated]
		internal static void BIZNNNXZOGW(Func<DDJDYJRQPZP, ZEWXQOUGCEM> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E540", Offset = "0x8B9CD40", VA = "0x188B9E540")]
		[CompilerGenerated]
		internal static bool JHAKNXMQJRX(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface NCLLFZEDSUU
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool CPCTBCOGHNX(MNBQIABPYXS a, MNBQIABPYXS b, IEnumerable<MNBQIABPYXS> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string XHXDCJVTHMG(VotekickFailReason a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public enum VotekickFailReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		InsufficientPermission,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		DisabledByRoom,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		CantKickEventOrganizer,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Broadcaster,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		GameInProgress,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		OpponentGameInProgress
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class MPCBOFCFWGV : NCLLFZEDSUU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly BNOTNEPADVS QNVWOFODUVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly RNBGQIWDUWP ZVNHKBIBFVX;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xABC070", Offset = "0xABA870", VA = "0x180ABC070")]
		[RecRoom.NoEngine.Common.Preserve]
		public MPCBOFCFWGV([Inject(null)] BNOTNEPADVS roomRoleManager, [Inject(null)] RNBGQIWDUWP gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8B98710", Offset = "0x8B96F10", VA = "0x188B98710")]
		private static PlayerEvent? KCMZLCWKHRU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B98610", Offset = "0x8B96E10", VA = "0x188B98610", Slot = "4")]
		public bool CPCTBCOGHNX(MNBQIABPYXS a, MNBQIABPYXS b, IEnumerable<MNBQIABPYXS> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B98D40", Offset = "0x8B97540", VA = "0x188B98D40", Slot = "5")]
		public string XHXDCJVTHMG(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B98750", Offset = "0x8B96F50", VA = "0x188B98750")]
		internal bool VTJVVRXMAWE(MNBQIABPYXS a, MNBQIABPYXS b, IEnumerable<MNBQIABPYXS> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
