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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA24D7D0", Offset = "0xA24C1D0", VA = "0x18A24D7D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA256C40", Offset = "0xA255640", VA = "0x18A256C40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
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
	public delegate void OnRoomRoleUpdated(JNIVCIZIPSX player);
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
	public interface BPASTRNPNEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool QZFWTFPKOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool CMNFOTTHIZO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool UESAHITENXU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool MITTDSLMCKB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool COXCAJCAXOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool EXUNNMJKYON
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool JQNVEWQCLIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class ILLKPIICIYU
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
		public static readonly Guid ANJMXUALPUA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid NHQIXBYSESR;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid XVBUPYHDPAO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid JTGJDNROPMW;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid BWPIAMQTLSV;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid BSLNDWAYEWE;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly DBPFKKWIZDP<AccountRoleType, Guid> UJEOORDTHUR;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> DYSNMKGAFTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA24C690", Offset = "0xA24B090", VA = "0x18A24C690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA24C700", Offset = "0xA24B100", VA = "0x18A24C700")]
		public static AccountRoleType TRPSZEGXDCT(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA24C790", Offset = "0xA24B190", VA = "0x18A24C790")]
		public static Guid WEFUKZGNZNF(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA24C430", Offset = "0xA24AE30", VA = "0x18A24C430")]
		public static bool CDDDXMHMKJS(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA24C570", Offset = "0xA24AF70", VA = "0x18A24C570")]
		public static bool HVHISJNEEPO(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA24C650", Offset = "0xA24B050", VA = "0x18A24C650")]
		public static AccountRoleType PGUZNXVOSRN(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA24C4C0", Offset = "0xA24AEC0", VA = "0x18A24C4C0")]
		public static DEPRECATED_RoomRoleId FAVNWUQLBLI(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA24C610", Offset = "0xA24B010", VA = "0x18A24C610")]
		internal static AccountRoleType OGSNYMOUGQZ(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface ITYCYZVWOPX
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance IQOBDWCPCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO AUSBPYUUCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> DSOPRGRPJRC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action GYKBQJOIWEC;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType ZRJLVDSMORS(JNIVCIZIPSX a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> OTTMBMTBRTP(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task POHARNOOWJH(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task GXBPMUJHTAH(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<JNIVCIZIPSX> WPUNYKZPYQK();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class JROSKYMHWHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA24CB20", Offset = "0xA24B520", VA = "0x18A24CB20")]
		public static AccountRoleType GYXZDWZWIQN(this ITYCYZVWOPX a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface KEBTQEWHDED : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		BQNXYLJDHBG KKWHENNFYRM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated KYZIOKAJHEC;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<RPVNLDQTIEQ> YGOMHMMEEEG(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RPVNLDQTIEQ UXOZJCIPOUU(JNIVCIZIPSX a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PIIJOGMELEV(JNIVCIZIPSX a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<RPVNLDQTIEQ> GFUQCDEFCZU(JNIVCIZIPSX a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TXZYSEIDBKO(JNIVCIZIPSX a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RPVNLDQTIEQ CQYTXMELWRZ(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ORYKOGYCCJH<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string GBYCNSJLQYH(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool WLGQOEZUMUT(JNIVCIZIPSX a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface WIPBGVUSSYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task GHOQQJMEHRZ(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface QEGMIUSPATQ<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> FBVNLDQESXL;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? KRHZTYADSHJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? WUGJNYUFDEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA24DC50", Offset = "0xA24C650", VA = "0x18A24DC50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA24DB60", Offset = "0xA24C560", VA = "0x18A24DB60")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA24DD20", Offset = "0xA24C720", VA = "0x18A24DD20")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool NMZJXIPHXOV(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> BCRQAPWOOPB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x75711E0", Offset = "0x756FBE0", VA = "0x1875711E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75720F0", Offset = "0x7570AF0", VA = "0x1875720F0", Slot = "4")]
		public override bool NMZJXIPHXOV(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7571820", Offset = "0x7570220", VA = "0x187571820")]
		public bool KAXXNAACNAN(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75725F0", Offset = "0x7570FF0", VA = "0x1875725F0")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class NLPHQTJTTES
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> IWGKLULGYUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> UULOFOEVYAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly CVIFWYYHQXP SXWRDCQOXOF;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA24D530", Offset = "0xA24BF30", VA = "0x18A24D530")]
		public NLPHQTJTTES(CVIFWYYHQXP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA24D2D0", Offset = "0xA24BCD0", VA = "0x18A24D2D0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D34870", Offset = "0x3D33270", VA = "0x183D34870")]
		public bool NBXAMDWDXPZ<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D34060", Offset = "0x3D32A60", VA = "0x183D34060")]
		public (bool, a?) DMRJCEQGWYP<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA24D1F0", Offset = "0xA24BBF0", VA = "0x18A24D1F0")]
		public bool NBXAMDWDXPZ(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA24D070", Offset = "0xA24BA70", VA = "0x18A24D070")]
		public (bool, object) DMRJCEQGWYP(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D34790", Offset = "0x3D33190", VA = "0x183D34790")]
		private void LBBNZMWJKDS<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA24CFA0", Offset = "0xA24B9A0", VA = "0x18A24CFA0")]
		private Permission CMSEULIWPSS(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA24D340", Offset = "0xA24BD40", VA = "0x18A24D340")]
		public void YBSIHEZINNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class CQSPJAVNIIR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string WWQWFWDTAVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type JIGBYTDRJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType NQKTSUYMENY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission SZASJZIMDBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet TBMCLAXFDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue WOZBQVHGXDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission ZFBMJDILDRI;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA247DC0", Offset = "0xA2467C0", VA = "0x18A247DC0")]
		public CQSPJAVNIIR(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA247CC0", Offset = "0xA2466C0", VA = "0x18A247CC0")]
		public object HMORGCVWXRZ(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3821430", Offset = "0x381FE30", VA = "0x183821430")]
		public void LBBNZMWJKDS<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA247D10", Offset = "0xA246710", VA = "0x18A247D10")]
		public void LBBNZMWJKDS(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class TLXRGCBRHNY<a> : CQSPJAVNIIR where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JOXUKJQLBDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet RSIGUEQGIDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue DCKNROQXXXN;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JOXUKJQLBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x67BC420", Offset = "0x67BAE20", VA = "0x1867BC420")]
			internal string WQYNYJNNSBU(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x67BC640", Offset = "0x67BB040", VA = "0x1867BC640")]
			internal object WRDUVQHLBND(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C52050", Offset = "0x7C50A50", VA = "0x187C52050")]
		public TLXRGCBRHNY(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C50D40", Offset = "0x7C4F740", VA = "0x187C50D40")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C51220", Offset = "0x7C4FC20", VA = "0x187C51220")]
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
	internal class CVIFWYYHQXP
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class NHXFZFRPVVJ : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static NHXFZFRPVVJ IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA24CB80", Offset = "0xA24B580", VA = "0x18A24CB80", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA24CCD0", Offset = "0xA24B6D0", VA = "0x18A24CCD0", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public NHXFZFRPVVJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class PIIGYECCHBL : DCDRIKKOMXS<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA24D850", Offset = "0xA24C250", VA = "0x18A24D850", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA24D940", Offset = "0xA24C340", VA = "0x18A24D940", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA24DAF0", Offset = "0xA24C4F0", VA = "0x18A24DAF0")]
			public PIIGYECCHBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly VVDVFDZUKYO DKASPJHKEUW;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly PIIGYECCHBL PGUIUWQOYNP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<CQSPJAVNIIR> QTNMMARCOEQ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> RKHGRQWOUKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, CQSPJAVNIIR> ATWMGCRBKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA249D70", Offset = "0xA248770", VA = "0x18A249D70")]
		public CVIFWYYHQXP([Optional] IList<CQSPJAVNIIR>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA247E60", Offset = "0xA246860", VA = "0x18A247E60")]
		public CQSPJAVNIIR JIXGKHAHJAQ(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface BQNXYLJDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		RPVNLDQTIEQ GULWXNWYALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class SZYFVECNLNP : BQNXYLJDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static SZYFVECNLNP QJTOPUAHCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly IFAUXZILORB ZEAIYHBFRWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<IFAUXZILORB> XOVCOEOVXQI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public RPVNLDQTIEQ GULWXNWYALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA24F0E0", Offset = "0xA24DAE0", VA = "0x18A24F0E0")]
		public SZYFVECNLNP(IFAUXZILORB a, IReadOnlyList<IFAUXZILORB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA24DFF0", Offset = "0xA24C9F0", VA = "0x18A24DFF0")]
		private static SZYFVECNLNP LEFPKCUNBNM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class TPTRHSWRZNZ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA24F270", Offset = "0xA24DC70", VA = "0x18A24F270")]
		public static KGOKKXWLORB DVKRTTPUNWT()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class BCMDUCTPTSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> VOMNKKKZZVN;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA2479C0", Offset = "0xA2463C0", VA = "0x18A2479C0")]
		public static bool HYIGRQPWHET(this JNIVCIZIPSX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA247AA0", Offset = "0xA2464A0", VA = "0x18A247AA0")]
		public static bool IGYESGAUCCY(this JNIVCIZIPSX a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface KURCCXOOBOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> WWCHYTZAHFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType AOCIPAVXOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface RPVNLDQTIEQ : KURCCXOOBOB, BPASTRNPNEN, QEGMIUSPATQ<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string ZHPQFGZRHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType HCXASSQSYPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) OJLFNUICEFD<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class IFAUXZILORB : RPVNLDQTIEQ, KURCCXOOBOB, BPASTRNPNEN, QEGMIUSPATQ<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly CVIFWYYHQXP CVIFWYYHQXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly NLPHQTJTTES QTQLZNCAWDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? ALJVDYXHLWX;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool DAEKUIWJOHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA24B590", Offset = "0xA249F90", VA = "0x18A24B590", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool IWGFDKOFLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA24B270", Offset = "0xA249C70", VA = "0x18A24B270", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool MOVHHPRJIBG
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA24B5E0", Offset = "0xA249FE0", VA = "0x18A24B5E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool JNMSKRSQOJN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA24B3F0", Offset = "0xA249DF0", VA = "0x18A24B3F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool MYJTULNQTPN
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA24ABB0", Offset = "0xA2495B0", VA = "0x18A24ABB0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool NQDWAOKMGEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA24B630", Offset = "0xA24A030", VA = "0x18A24B630", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool DVVSQVLBNYM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA24B440", Offset = "0xA249E40", VA = "0x18A24B440", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType HCXASSQSYPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0EF00", Offset = "0xD0D900", VA = "0x180D0EF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FC20", Offset = "0x8A1E620", VA = "0x188A1FC20", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7F0", Offset = "0xD0A1F0", VA = "0x180D0B7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ZHPQFGZRHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FC20", Offset = "0x8A1E620", VA = "0x188A1FC20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool GHLNSOTCFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD677E0", Offset = "0xD661E0", VA = "0x180D677E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType AOCIPAVXOKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA24B060", Offset = "0xA249A60", VA = "0x18A24B060", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> WWCHYTZAHFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA24C1B0", Offset = "0xA24ABB0", VA = "0x18A24C1B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool WNSBDQHJPQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA24B590", Offset = "0xA249F90", VA = "0x18A24B590", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ONMDNMAHOXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA24ABB0", Offset = "0xA2495B0", VA = "0x18A24ABB0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool KBPUHMKHWOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA24B270", Offset = "0xA249C70", VA = "0x18A24B270", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool FIPPCSHTDBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA24B5E0", Offset = "0xA249FE0", VA = "0x18A24B5E0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool BADLVILTOVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA24B3F0", Offset = "0xA249DF0", VA = "0x18A24B3F0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool RKMURSMXBPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA24B630", Offset = "0xA24A030", VA = "0x18A24B630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool SAOZFBXIBYO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA24B440", Offset = "0xA249E40", VA = "0x18A24B440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> FBVNLDQESXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA24C100", Offset = "0xA24AB00", VA = "0x18A24C100", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA24AC00", Offset = "0xA249600", VA = "0x18A24AC00", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3B81140", Offset = "0x3B7FB40", VA = "0x183B81140", Slot = "6")]
		public (bool, a?) OJLFNUICEFD<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B80F00", Offset = "0x3B7F900", VA = "0x183B80F00")]
		public IFAUXZILORB APFUMGOLICV<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA24C410", Offset = "0xA24AE10", VA = "0x18A24C410")]
		public IFAUXZILORB(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA24C280", Offset = "0xA24AC80", VA = "0x18A24C280")]
		public IFAUXZILORB(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA24C2A0", Offset = "0xA24ACA0", VA = "0x18A24C2A0")]
		public IFAUXZILORB(IFAUXZILORB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA24C2F0", Offset = "0xA24ACF0", VA = "0x18A24C2F0")]
		internal IFAUXZILORB(AccountRoleType a, [Optional] string? b, [Optional] IFAUXZILORB? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA24B710", Offset = "0xA24A110", VA = "0x18A24B710")]
		public static RolePermissionType RFVRUSHWFGP(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA24C0E0", Offset = "0xA24AAE0", VA = "0x18A24C0E0")]
		public void YBSIHEZINNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA24A8C0", Offset = "0xA2492C0", VA = "0x18A24A8C0")]
		internal IFAUXZILORB ASEEJXJLRJD(IFAUXZILORB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA24ACB0", Offset = "0xA2496B0", VA = "0x18A24ACB0")]
		internal IReadOnlyCollection<RolePermission> Copy(IFAUXZILORB roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA24B310", Offset = "0xA249D10", VA = "0x18A24B310")]
		public bool FNZNRTBRVVS(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA24B490", Offset = "0xA249E90", VA = "0x18A24B490")]
		public (bool, string) JZEBBLTPIHH(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA24B2C0", Offset = "0xA249CC0", VA = "0x18A24B2C0")]
		internal void FNNLXEAOFKC(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA24B0B0", Offset = "0xA249AB0", VA = "0x18A24B0B0")]
		public OXNMPIDRXMC ECEZEAWUTPS(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA24B780", Offset = "0xA24A180", VA = "0x18A24B780")]
		public void WAEODPOBANK(OXNMPIDRXMC a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA24B680", Offset = "0xA24A080", VA = "0x18A24B680")]
		[CompilerGenerated]
		private void RECHVWOYSVS(RolePermission a, BHUMYXXICVX b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class WXOXYAWQQII : WIPBGVUSSYM, KEBTQEWHDED, IDisposable, EOVRJDZRSHF
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class PXDVPQKQEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public IFAUXZILORB DYGIWJYKSBQ;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public PXDVPQKQEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA24DB30", Offset = "0xA24C530", VA = "0x18A24DB30")]
			internal bool FDNZRUPCROW(IFAUXZILORB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class OBFTOIQSFGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType BMKARZPLDYY;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public OBFTOIQSFGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD9D0", Offset = "0x1EFC3D0", VA = "0x181EFD9D0")]
			internal bool TPWMZNTHQIA(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class QBOOQFVFXIX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder ZJXBCAYITIK;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public QBOOQFVFXIX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA24DF10", Offset = "0xA24C910", VA = "0x18A24DF10")]
			internal void HNGODQXMUGZ(OXNMPIDRXMC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA24DE10", Offset = "0xA24C810", VA = "0x18A24DE10")]
			internal void HNBHGKDPKVQ(OXNMPIDRXMC a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct <>c__DisplayClass35_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PersistedRoomData roomData;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class TNZXGVDNUMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<OXNMPIDRXMC, BHUMYXXICVX> URFRALHELDA;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public TNZXGVDNUMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA24F240", Offset = "0xA24DC40", VA = "0x18A24F240")]
			internal void GXPBKEQQDUO(OXNMPIDRXMC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA24F210", Offset = "0xA24DC10", VA = "0x18A24F210")]
			internal void GXJUMXWSUJF(OXNMPIDRXMC a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA24F1E0", Offset = "0xA24DBE0", VA = "0x18A24F1E0")]
			internal void GXENPRCVKXW(OXNMPIDRXMC a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class XNRBKLKAGUH<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000032")]
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
				public XNRBKLKAGUH<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x41D4240", Offset = "0x41D2C40", VA = "0x1841D4240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD6DE70", Offset = "0xD6C870", VA = "0x180D6DE70", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission VVAPKCFFIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType VDCEWLZNIWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool HJITTNBDAVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType ERTVRIAIBTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string IBIJZMAHJTD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public WXOXYAWQQII AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action UEKYUNLIFTI;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XNRBKLKAGUH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x50CA3F0", Offset = "0x50C8DF0", VA = "0x1850CA3F0")]
			[AsyncStateMachine(typeof(XNRBKLKAGUH<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void YSKPQPSGSKA()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct <>c__DisplayClass51_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public IReadOnlyList<RolePermissionDTO> newPermissionOverrides;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
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
			public ITYCYZVWOPX rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, IFAUXZILORB> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public LARVDFBNSQK debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA24F520", Offset = "0xA24DF20", VA = "0x18A24F520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA250020", Offset = "0xA24EA20", VA = "0x18A250020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
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
			public WXOXYAWQQII <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA250080", Offset = "0xA24EA80", VA = "0x18A250080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA2506F0", Offset = "0xA24F0F0", VA = "0x18A2506F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly ITYCYZVWOPX XJJKPHABOVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly SZYFVECNLNP BOICQEOSVSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly LARVDFBNSQK YSBIRVQLGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private WVRHQELONBC? WWYVDPMHOUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> UMFUCSCCBNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, IFAUXZILORB> NWATZLQDFXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, IFAUXZILORB> XPIXDDPKDVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, IFAUXZILORB> XJDWFPAZDSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<IFAUXZILORB> GGQWUFSYTNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool OMICLTVYOWI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] ROIPLWGJMWU;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BQNXYLJDHBG KKWHENNFYRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated KYZIOKAJHEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA254F70", Offset = "0xA253970", VA = "0x18A254F70", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA2564D0", Offset = "0xA254ED0", VA = "0x18A2564D0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2549C0", Offset = "0xA2533C0", VA = "0x18A2549C0")]
		[ONTQUCAGRJW.Room]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA256990", Offset = "0xA255390", VA = "0x18A256990")]
		[UnityEngine.Scripting.Preserve]
		internal WXOXYAWQQII([Inject(null)] ITYCYZVWOPX roleDataProvider, [Inject(null)] SZYFVECNLNP roleManagerDefaults, [Inject(null)] LARVDFBNSQK debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA251A10", Offset = "0xA250410", VA = "0x18A251A10", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA253E30", Offset = "0xA252830", VA = "0x18A253E30")]
		private void NJDOOMKCOXS(IEnumerable<IFAUXZILORB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA254B70", Offset = "0xA253570", VA = "0x18A254B70", Slot = "10")]
		public bool PIIJOGMELEV(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA251DE0", Offset = "0xA2507E0", VA = "0x18A251DE0")]
		private void GYKBQJOIWEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA251510", Offset = "0xA24FF10", VA = "0x18A251510", Slot = "19")]
		public void COWFAGSZKKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA256450", Offset = "0xA254E50", VA = "0x18A256450", Slot = "8")]
		public IReadOnlyList<RPVNLDQTIEQ> YGOMHMMEEEG(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA255450", Offset = "0xA253E50", VA = "0x18A255450", Slot = "9")]
		public RPVNLDQTIEQ UXOZJCIPOUU(JNIVCIZIPSX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA252460", Offset = "0xA250E60", VA = "0x18A252460")]
		private AccountRoleType IJMNXWTZHXS(JNIVCIZIPSX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA255210", Offset = "0xA253C10", VA = "0x18A255210", Slot = "12")]
		public bool TXZYSEIDBKO(JNIVCIZIPSX a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2516F0", Offset = "0xA2500F0", VA = "0x18A2516F0", Slot = "13")]
		public RPVNLDQTIEQ CQYTXMELWRZ(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA251DF0", Offset = "0xA2507F0", VA = "0x18A251DF0")]
		private static bool HHPWEXPWZFO(KGOKKXWLORB a, AccountRoleType b, [Out] OXNMPIDRXMC? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA251420", Offset = "0xA24FE20", VA = "0x18A251420")]
		private static void BRZCVOYPTQK(KGOKKXWLORB a, Action<OXNMPIDRXMC> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA251190", Offset = "0xA24FB90", VA = "0x18A251190")]
		private static void BRZCVOYPTQK(KGOKKXWLORB a, Action<OXNMPIDRXMC> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2553E0", Offset = "0xA253DE0", VA = "0x18A2553E0")]
		private void UUCILUEXVBJ(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA251CC0", Offset = "0xA2506C0", VA = "0x18A251CC0", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task GHOQQJMEHRZ([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA254690", Offset = "0xA253090", VA = "0x18A254690")]
		private void ODIYOMZGDIT(KGOKKXWLORB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA250E90", Offset = "0xA24F890", VA = "0x18A250E90")]
		internal static string BNSFDROFDOB(ITYCYZVWOPX a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IFAUXZILORB> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA252530", Offset = "0xA250F30", VA = "0x18A252530")]
		private static void ILFLDJQWGBX(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA252120", Offset = "0xA250B20", VA = "0x18A252120")]
		private static void IDZDBJGOYGK(KGOKKXWLORB a, IReadOnlyDictionary<AccountRoleType, IFAUXZILORB> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2552D0", Offset = "0xA253CD0", VA = "0x18A2552D0")]
		private static bool USQOQSKUYNP(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA255A50", Offset = "0xA254450", VA = "0x18A255A50")]
		private static void XGMWTEGJRHE(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4125E20", Offset = "0x4124820", VA = "0x184125E20", Slot = "14")]
		public bool ORYKOGYCCJH<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA251B10", Offset = "0xA250510", VA = "0x18A251B10", Slot = "15")]
		public string GBYCNSJLQYH(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA255840", Offset = "0xA254240", VA = "0x18A255840", Slot = "16")]
		public bool WLGQOEZUMUT(JNIVCIZIPSX a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA251B80", Offset = "0xA250580", VA = "0x18A251B80", Slot = "18")]
		public bool GEHNDKWNHSD(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA255010", Offset = "0xA253A10", VA = "0x18A255010")]
		private void TBMSSOHQROJ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA254D80", Offset = "0xA253780", VA = "0x18A254D80")]
		private bool PlayerHasRole(JNIVCIZIPSX player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2555B0", Offset = "0xA253FB0", VA = "0x18A2555B0")]
		private IFAUXZILORB WKQPMDPNGJB(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA256570", Offset = "0xA254F70", VA = "0x18A256570")]
		internal AccountRoleType ZZOWUIWMCKR(JNIVCIZIPSX a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA254C40", Offset = "0xA253640", VA = "0x18A254C40")]
		private void PUAWWZJTRKZ(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA251C40", Offset = "0xA250640", VA = "0x18A251C40", Slot = "11")]
		public IReadOnlyList<RPVNLDQTIEQ> GFUQCDEFCZU(JNIVCIZIPSX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA251C40", Offset = "0xA250640", VA = "0x18A251C40")]
		internal IReadOnlyList<IFAUXZILORB> QMFVMJFOEUL(JNIVCIZIPSX a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA254DA0", Offset = "0xA2537A0", VA = "0x18A254DA0")]
		internal IReadOnlyList<IFAUXZILORB> SVQSLRWPLNR(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA253210", Offset = "0xA251C10", VA = "0x18A253210")]
		private void JKEEZMLERNO(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA256170", Offset = "0xA254B70", VA = "0x18A256170")]
		private static bool YAANFEPQTWQ(IFAUXZILORB a, IReadOnlyDictionary<AccountRoleType, IFAUXZILORB> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA253980", Offset = "0xA252380", VA = "0x18A253980")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task JTUPILAQOUK(ITYCYZVWOPX a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, IFAUXZILORB> c, LARVDFBNSQK d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA251790", Offset = "0xA250190", VA = "0x18A251790")]
		[CompilerGenerated]
		internal static void DEJEKPGKKLF(Func<OXNMPIDRXMC, BHUMYXXICVX> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA253AC0", Offset = "0xA2524C0", VA = "0x18A253AC0")]
		[CompilerGenerated]
		internal static bool LGRKEJPRDSI(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface DCKBDHBAJYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VRXEIEAFPJW(JNIVCIZIPSX a, JNIVCIZIPSX b, IEnumerable<JNIVCIZIPSX> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string KKKXHAQRNAZ(VotekickFailReason a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
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
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal class EVUDIUEGMHM : DCKBDHBAJYB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly KEBTQEWHDED FQRMLRWHQWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly THLMZWZFAKY IKLYZHDMBOK;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD0DA70", Offset = "0xD0C470", VA = "0x180D0DA70")]
		[RecRoom.NoEngine.Common.Preserve]
		public EVUDIUEGMHM([Inject(null)] KEBTQEWHDED roomRoleManager, [Inject(null)] THLMZWZFAKY gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA24A680", Offset = "0xA249080", VA = "0x18A24A680")]
		private static PlayerEvent? KHKTCODSKQR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA24A7C0", Offset = "0xA2491C0", VA = "0x18A24A7C0", Slot = "4")]
		public bool VRXEIEAFPJW(JNIVCIZIPSX a, JNIVCIZIPSX b, IEnumerable<JNIVCIZIPSX> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA24A6C0", Offset = "0xA2490C0", VA = "0x18A24A6C0", Slot = "5")]
		public string KKKXHAQRNAZ(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA24A080", Offset = "0xA248A80", VA = "0x18A24A080")]
		internal bool GBGECTNSPKN(JNIVCIZIPSX a, JNIVCIZIPSX b, IEnumerable<JNIVCIZIPSX> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
