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
		[Cpp2IlInjected.Address(RVA = "0x8DAEAC0", Offset = "0x8DAD0C0", VA = "0x188DAEAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DB36A0", Offset = "0x8DB1CA0", VA = "0x188DB36A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
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
	public delegate void OnRoomRoleUpdated(LRIABUPBGVB player);
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
	public interface VONQIZDWYFT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool EAALYCEKNZY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LUDLFXYVHZW
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool NTPRCZBBZAW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IGAAOEISQMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool LEEROYAGIKY
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool TMWMJTETIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool OQCIUEGMMWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class WFMSYCCTKPS
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
		public static readonly Guid TZTMWOXCCHC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid SELAEKOCLOB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid YASVYNSJKFE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid FKFLEYOFRQK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid VMZTSDAFATL;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid IYOLDRHSLDS;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly DBORJULKVGN<AccountRoleType, Guid> OPDRWJVJLDH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> AYUPRXLBPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8DB28D0", Offset = "0x8DB0ED0", VA = "0x188DB28D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2840", Offset = "0x8DB0E40", VA = "0x188DB2840")]
		public static AccountRoleType BILDMWFCHYL(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DB29C0", Offset = "0x8DB0FC0", VA = "0x188DB29C0")]
		public static Guid TKVIPCKKMFN(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2B00", Offset = "0x8DB1100", VA = "0x188DB2B00")]
		public static bool VCUMCWLGRNK(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2A60", Offset = "0x8DB1060", VA = "0x188DB2A60")]
		public static bool UUYRRJCIJXW(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2940", Offset = "0x8DB0F40", VA = "0x188DB2940")]
		public static AccountRoleType OLIJPAQYCRR(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2790", Offset = "0x8DB0D90", VA = "0x188DB2790")]
		public static DEPRECATED_RoomRoleId ASHOOQEVGEO(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2980", Offset = "0x8DB0F80", VA = "0x188DB2980")]
		internal static AccountRoleType RMDQBTWJUZD(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QVELLFEGMYR
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance QLKKXRREVAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO YFHFIOAYXFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> ZSWJAVQGWNC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action UFRMEGCXDFY;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType EEIHADFZJCA(LRIABUPBGVB a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> GRKKKBFLHRP(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task TKMZVIVYZHL(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task EIOALKGOZRJ(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<LRIABUPBGVB> HRSPRRJGHNA();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class CAOCRZXUKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4F90", Offset = "0x8DA3590", VA = "0x188DA4F90")]
		public static AccountRoleType JYRJWFUWZZL(this QVELLFEGMYR a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface KMZIONLGUAD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		DBGNZAPRJOI EYMUXKQGOXE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated BDUQLHWPAQC;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<SWWZAYLJWPW> IXAJNSUGAAC(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SWWZAYLJWPW DXTIJSCDAAY(LRIABUPBGVB a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EKLCYVSDKLH(LRIABUPBGVB a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<SWWZAYLJWPW> VSSPEGGQBGC(LRIABUPBGVB a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PQXTZGDUOJA(LRIABUPBGVB a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SWWZAYLJWPW TKXRTRRYFED(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool LQAICWFYPDT<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string FXNGGFTAKZZ(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool UJFYTXUIXCX(LRIABUPBGVB a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GQHIIHMBJQE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task UPUEKEUQYDV(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KIHXPDOEABY<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> DQVJTIJKGHX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? KVISLSOZDRF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? KIATWXMOFYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8DAEB40", Offset = "0x8DAD140", VA = "0x188DAEB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8DAEC10", Offset = "0x8DAD210", VA = "0x188DAEC10")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8DAED10", Offset = "0x8DAD310", VA = "0x188DAED10")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool MHYZRYTYABP(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> TXYHIMMVDGL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5CB0320", Offset = "0x5CAE920", VA = "0x185CB0320")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5CAF800", Offset = "0x5CADE00", VA = "0x185CAF800", Slot = "4")]
		public override bool MHYZRYTYABP(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CAFC80", Offset = "0x5CAE280", VA = "0x185CAFC80")]
		public bool THKJCLMJPEZ(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5CB0540", Offset = "0x5CAEB40", VA = "0x185CB0540")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class XLRHCMRNLFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> EMEFZEUEVYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> BUJVABOFXYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly DORUXYHTIKN LEPWGFCHRMF;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3410", Offset = "0x8DB1A10", VA = "0x188DB3410")]
		public XLRHCMRNLFE(DORUXYHTIKN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8DB30F0", Offset = "0x8DB16F0", VA = "0x188DB30F0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4C60", Offset = "0x3ED3260", VA = "0x183ED4C60")]
		public bool FMZTVPKFWUX<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4530", Offset = "0x3ED2B30", VA = "0x183ED4530")]
		public (bool, a?) DCIHVBPINQH<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3010", Offset = "0x8DB1610", VA = "0x188DB3010")]
		public bool FMZTVPKFWUX(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2E80", Offset = "0x8DB1480", VA = "0x188DB2E80")]
		public (bool, object) DCIHVBPINQH(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5420", Offset = "0x3ED3A20", VA = "0x183ED5420")]
		private void SPATPJGGLZO<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3340", Offset = "0x8DB1940", VA = "0x188DB3340")]
		private Permission YRFEQFXXTSO(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3160", Offset = "0x8DB1760", VA = "0x188DB3160")]
		public void TVCLYPQEWAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class UZNNNRPVSOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string YHRYJBCAKUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type FSOUVPMUIQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType KJCNRFVHQOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission PTHVHYJSECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet PZXTCRDHHYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue HTHIWFDHQMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission DHSCXYKJNRE;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8DB26F0", Offset = "0x8DB0CF0", VA = "0x188DB26F0")]
		public UZNNNRPVSOJ(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB26A0", Offset = "0x8DB0CA0", VA = "0x188DB26A0")]
		public object XZBEZDTQJTZ(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E73AE0", Offset = "0x3E720E0", VA = "0x183E73AE0")]
		public void SPATPJGGLZO<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB25F0", Offset = "0x8DB0BF0", VA = "0x188DB25F0")]
		public void SPATPJGGLZO(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class IKFKQMVFTNE<a> : UZNNNRPVSOJ where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet WZKOTBGORQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue ZMJDORHTGLV;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x56B2AD0", Offset = "0x56B10D0", VA = "0x1856B2AD0")]
			internal string LZNYXWZVGYS(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x56B2F60", Offset = "0x56B1560", VA = "0x1856B2F60")]
			internal object LZTFVDTSQKB(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x51D7170", Offset = "0x51D5770", VA = "0x1851D7170")]
		public IKFKQMVFTNE(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x51D6090", Offset = "0x51D4690", VA = "0x1851D6090")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x51D6980", Offset = "0x51D4F80", VA = "0x1851D6980")]
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
	internal class DORUXYHTIKN
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class GRTBWMGVCSP : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static GRTBWMGVCSP ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8DA83C0", Offset = "0x8DA69C0", VA = "0x188DA83C0", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8510", Offset = "0x8DA6B10", VA = "0x188DA8510", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GRTBWMGVCSP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class LJCSWKLCYNL : ADFSYRSKXAQ<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE7B0", Offset = "0x8DACDB0", VA = "0x188DAE7B0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE600", Offset = "0x8DACC00", VA = "0x188DAE600", Slot = "10")]
			protected override bool RQBBEHZZNEF(string a, [Out] VotekickType b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE8A0", Offset = "0x8DACEA0", VA = "0x188DAE8A0")]
			public LJCSWKLCYNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly HOWUGWJFNQG TQWKTAMULIW;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly LJCSWKLCYNL VNHJYKNGFSV;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<UZNNNRPVSOJ> GXVZIOHDZVW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> BKTKIOVVOBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, UZNNNRPVSOJ> VURHCWDPRSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8080", Offset = "0x8DA6680", VA = "0x188DA8080")]
		public DORUXYHTIKN([Optional] IList<UZNNNRPVSOJ>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8DA61D0", Offset = "0x8DA47D0", VA = "0x188DA61D0")]
		public UZNNNRPVSOJ CYHRJHSYTJS(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface DBGNZAPRJOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		SWWZAYLJWPW EJBYAOSJGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class CQMKTYGUIJP : DBGNZAPRJOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static CQMKTYGUIJP ICMZBMGNOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly UCJNRTNWHRJ YWGFMTTJAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<UCJNRTNWHRJ> QOMTOEXPPNC;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SWWZAYLJWPW EJBYAOSJGIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8DA60D0", Offset = "0x8DA46D0", VA = "0x188DA60D0")]
		public CQMKTYGUIJP(UCJNRTNWHRJ a, IReadOnlyList<UCJNRTNWHRJ> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4FF0", Offset = "0x8DA35F0", VA = "0x188DA4FF0")]
		private static CQMKTYGUIJP AJPTULUGYKK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class TCLXRHDXUUE
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> FDEWZVOWSFF;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEE90", Offset = "0x8DAD490", VA = "0x188DAEE90")]
		public static bool RSFYNRPPKVR(this LRIABUPBGVB a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEE10", Offset = "0x8DAD410", VA = "0x188DAEE10")]
		public static bool DQGXNHRTPWI(this LRIABUPBGVB a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BBPWSOXWLHL
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> FYCIPLHYHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType XJZRVGJGXJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface SWWZAYLJWPW : BBPWSOXWLHL, VONQIZDWYFT, KIHXPDOEABY<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string BBBDTXWGGGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType BOQCYVIGVKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) YVVRJGOMPJT<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class UCJNRTNWHRJ : SWWZAYLJWPW, BBPWSOXWLHL, VONQIZDWYFT, KIHXPDOEABY<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly DORUXYHTIKN DORUXYHTIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly XLRHCMRNLFE ZAQMWTZFTKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? KZXKSYBVEID;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool WKIMOMPYFNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1A40", Offset = "0x8DB0040", VA = "0x188DB1A40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool UOIUYMTLILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1C50", Offset = "0x8DB0250", VA = "0x188DB1C50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool DLGKHOSCAGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0AF0", Offset = "0x8DAF0F0", VA = "0x188DB0AF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool SPASSDTQUYL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0C40", Offset = "0x8DAF240", VA = "0x188DB0C40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool FRRYMDBKQET
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1CA0", Offset = "0x8DB02A0", VA = "0x188DB1CA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool OXVYTVPELFI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8DB19F0", Offset = "0x8DAFFF0", VA = "0x188DB19F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool RHTGHXYOFJG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0B40", Offset = "0x8DAF140", VA = "0x188DB0B40", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType BOQCYVIGVKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x758C950", Offset = "0x758AF50", VA = "0x18758C950", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string BBBDTXWGGGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x758C950", Offset = "0x758AF50", VA = "0x18758C950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool QPLFNKRRIKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType XJZRVGJGXJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0C90", Offset = "0x8DAF290", VA = "0x188DB0C90", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> FYCIPLHYHSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2080", Offset = "0x8DB0680", VA = "0x188DB2080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool KMHVYJIVBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1A40", Offset = "0x8DB0040", VA = "0x188DB1A40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool SAONASEEJSF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1CA0", Offset = "0x8DB02A0", VA = "0x188DB1CA0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool NIZCMMJZNHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1C50", Offset = "0x8DB0250", VA = "0x188DB1C50", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ROUIZXMHCNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0AF0", Offset = "0x8DAF0F0", VA = "0x188DB0AF0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool XWXAGYHWFCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0C40", Offset = "0x8DAF240", VA = "0x188DB0C40", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool QOGONSMUJMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8DB19F0", Offset = "0x8DAFFF0", VA = "0x188DB19F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OTLCAEFCUWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0B40", Offset = "0x8DAF140", VA = "0x188DB0B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> DQVJTIJKGHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0B90", Offset = "0x8DAF190", VA = "0x188DB0B90", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8DB1CF0", Offset = "0x8DB02F0", VA = "0x188DB1CF0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A410", Offset = "0x3E68A10", VA = "0x183E6A410", Slot = "6")]
		public (bool, a?) YVVRJGOMPJT<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A1D0", Offset = "0x3E687D0", VA = "0x183E6A1D0")]
		public UCJNRTNWHRJ AWTCQFNSAGB<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2440", Offset = "0x8DB0A40", VA = "0x188DB2440")]
		public UCJNRTNWHRJ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2460", Offset = "0x8DB0A60", VA = "0x188DB2460")]
		public UCJNRTNWHRJ(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB25A0", Offset = "0x8DB0BA0", VA = "0x188DB25A0")]
		public UCJNRTNWHRJ(UCJNRTNWHRJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2480", Offset = "0x8DB0A80", VA = "0x188DB2480")]
		internal UCJNRTNWHRJ(AccountRoleType a, [Optional] string? b, [Optional] UCJNRTNWHRJ? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB0A80", Offset = "0x8DAF080", VA = "0x188DB0A80")]
		public static RolePermissionType AVJYNSAZDSL(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1ED0", Offset = "0x8DB04D0", VA = "0x188DB1ED0")]
		public void TVCLYPQEWAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB20E0", Offset = "0x8DB06E0", VA = "0x188DB20E0")]
		internal UCJNRTNWHRJ YZRYNDJETQJ(UCJNRTNWHRJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB0CE0", Offset = "0x8DAF2E0", VA = "0x188DB0CE0")]
		internal IReadOnlyCollection<RolePermission> Copy(UCJNRTNWHRJ roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1DF0", Offset = "0x8DB03F0", VA = "0x188DB1DF0")]
		public bool SLWLFUZWNVG(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1EF0", Offset = "0x8DB04F0", VA = "0x188DB1EF0")]
		public (bool, string) TYBRHEJQLBT(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1DA0", Offset = "0x8DB03A0", VA = "0x188DB1DA0")]
		internal void OCDTEVPBVWW(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1A90", Offset = "0x8DB0090", VA = "0x188DB1A90")]
		public JLWDXOKAAZI LYOLGHBTQSE(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1090", Offset = "0x8DAF690", VA = "0x188DB1090")]
		public void DNOMSENYTME(JLWDXOKAAZI a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1FF0", Offset = "0x8DB05F0", VA = "0x188DB1FF0")]
		[CompilerGenerated]
		private void XISFYDOBVIM(RolePermission a, NCIYKWISPVH b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class HBUDTWRXIEE : GQHIIHMBJQE, KMZIONLGUAD, IDisposable, ESILARESUHZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class GLDZIWPLILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public UCJNRTNWHRJ GRMEYMQXMNU;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GLDZIWPLILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8DA8390", Offset = "0x8DA6990", VA = "0x188DA8390")]
			internal bool UTYOSLOUFPI(UCJNRTNWHRJ a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class BUHEGFXHPGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType GHMEBYSZFEU;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public BUHEGFXHPGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1FA50A0", Offset = "0x1FA36A0", VA = "0x181FA50A0")]
			internal bool HDBHHYHFEIU(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class NUCXBFCPWAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder FUKKODHETZE;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NUCXBFCPWAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE9E0", Offset = "0x8DACFE0", VA = "0x188DAE9E0")]
			internal void PSHTTAOXBZD(JLWDXOKAAZI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE8E0", Offset = "0x8DACEE0", VA = "0x188DAE8E0")]
			internal void PSCMVTUZSNU(JLWDXOKAAZI a)
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
		private sealed class JDULPBULCCT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<JLWDXOKAAZI, NCIYKWISPVH> WKSQTPPTEXY;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public JDULPBULCCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE5D0", Offset = "0x8DACBD0", VA = "0x188DAE5D0")]
			internal void FQKOXVPINIK(JLWDXOKAAZI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE5A0", Offset = "0x8DACBA0", VA = "0x188DAE5A0")]
			internal void FQFIAOVLDXB(JLWDXOKAAZI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8DAE570", Offset = "0x8DACB70", VA = "0x188DAE570")]
			internal void FQABDIBNULS(JLWDXOKAAZI a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class NKEGQJZDDKL<a> where a : notnull
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
				public NKEGQJZDDKL<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x3F8C9F0", Offset = "0x3F8AFF0", VA = "0x183F8C9F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission GBGLKBFDUXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType WJSTBMTQZTZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool RAOBVIPYUWV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType QKOUUSDNIXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string WEJTNUQFLUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HBUDTWRXIEE CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action BNLBRCWLEYW;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NKEGQJZDDKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5A73890", Offset = "0x5A71E90", VA = "0x185A73890")]
			[AsyncStateMachine(typeof(NKEGQJZDDKL<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void PYAMPMRTTLW()
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
			public QVELLFEGMYR rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, UCJNRTNWHRJ> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public LUVOEAWCUWK debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8DAF110", Offset = "0x8DAD710", VA = "0x188DAF110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8DAFC10", Offset = "0x8DAE210", VA = "0x188DAFC10", Slot = "5")]
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
			public HBUDTWRXIEE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8DAFC70", Offset = "0x8DAE270", VA = "0x188DAFC70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8DB02E0", Offset = "0x8DAE8E0", VA = "0x188DB02E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly QVELLFEGMYR LEVZHNQELRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly CQMKTYGUIJP ASVYPJEPHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly LUVOEAWCUWK PYGTUNQHVVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private SZFUVYZIPQY? OQHDICIWJJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> RFRCMJBMBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, UCJNRTNWHRJ> DQOQJNEVHFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, UCJNRTNWHRJ> QFDSGHPEHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, UCJNRTNWHRJ> TJNJKLTZLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<UCJNRTNWHRJ> EWFPYCFTVSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool NJLQBASPTKA;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] QYOCZCNDLDK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public DBGNZAPRJOI EYMUXKQGOXE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated BDUQLHWPAQC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8DA9960", Offset = "0x8DA7F60", VA = "0x188DA9960", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8DADBE0", Offset = "0x8DAC1E0", VA = "0x188DADBE0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DADCF0", Offset = "0x8DAC2F0", VA = "0x188DADCF0")]
		[ZOKCDQOPSGU.Room]
		internal static void ZOKCDQOPSGU(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE2C0", Offset = "0x8DAC8C0", VA = "0x188DAE2C0")]
		[UnityEngine.Scripting.Preserve]
		internal HBUDTWRXIEE([Inject(null)] QVELLFEGMYR roleDataProvider, [Inject(null)] CQMKTYGUIJP roleManagerDefaults, [Inject(null)] LUVOEAWCUWK debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9E90", Offset = "0x8DA8490", VA = "0x188DA9E90", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAB50", Offset = "0x8DA9150", VA = "0x188DAAB50")]
		private void IJPNTRKBYTW(IEnumerable<UCJNRTNWHRJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA0A0", Offset = "0x8DA86A0", VA = "0x188DAA0A0", Slot = "10")]
		public bool EKLCYVSDKLH(LRIABUPBGVB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DACDF0", Offset = "0x8DAB3F0", VA = "0x188DACDF0")]
		private void UFRMEGCXDFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DADA00", Offset = "0x8DAC000", VA = "0x188DADA00", Slot = "19")]
		public void YLQLGVLKKTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB3B0", Offset = "0x8DA99B0", VA = "0x188DAB3B0", Slot = "8")]
		public IReadOnlyList<SWWZAYLJWPW> IXAJNSUGAAC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9D30", Offset = "0x8DA8330", VA = "0x188DA9D30", Slot = "9")]
		public SWWZAYLJWPW DXTIJSCDAAY(LRIABUPBGVB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC940", Offset = "0x8DAAF40", VA = "0x188DAC940")]
		private AccountRoleType TEVEZYPAJJC(LRIABUPBGVB a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC4A0", Offset = "0x8DAAAA0", VA = "0x188DAC4A0", Slot = "12")]
		public bool PQXTZGDUOJA(LRIABUPBGVB a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DACA10", Offset = "0x8DAB010", VA = "0x188DACA10", Slot = "13")]
		public SWWZAYLJWPW TKXRTRRYFED(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA87D0", Offset = "0x8DA6DD0", VA = "0x188DA87D0")]
		private static bool AXMTSPDKTAU(IGSMESIYCNN a, AccountRoleType b, [Out] JLWDXOKAAZI? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA95E0", Offset = "0x8DA7BE0", VA = "0x188DA95E0")]
		private static void CDSSTBXCDLI(IGSMESIYCNN a, Action<JLWDXOKAAZI> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA96D0", Offset = "0x8DA7CD0", VA = "0x188DA96D0")]
		private static void CDSSTBXCDLI(IGSMESIYCNN a, Action<JLWDXOKAAZI> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DADC80", Offset = "0x8DAC280", VA = "0x188DADC80")]
		private void YPUNBFHYTDZ(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD010", Offset = "0x8DAB610", VA = "0x188DAD010", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task UPUEKEUQYDV([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9A00", Offset = "0x8DA8000", VA = "0x188DA9A00")]
		private void DVRKBLXIMVB(IGSMESIYCNN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC640", Offset = "0x8DAAC40", VA = "0x188DAC640")]
		internal static string RTFFMRPERYR(QVELLFEGMYR a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, UCJNRTNWHRJ> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB570", Offset = "0x8DA9B70", VA = "0x188DAB570")]
		private static void KNOTXHODJON(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DACAB0", Offset = "0x8DAB0B0", VA = "0x188DACAB0")]
		private static void TWFAXAAWICO(IGSMESIYCNN a, IReadOnlyDictionary<AccountRoleType, UCJNRTNWHRJ> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9F90", Offset = "0x8DA8590", VA = "0x188DA9F90")]
		private static bool EIXNYUYHKOZ(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8EC0", Offset = "0x8DA74C0", VA = "0x188DA8EC0")]
		private static void CCTRBRHTZAW(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x38EC5E0", Offset = "0x38EABE0", VA = "0x1838EC5E0", Slot = "14")]
		public bool LQAICWFYPDT<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA8E0", Offset = "0x8DA8EE0", VA = "0x188DAA8E0", Slot = "15")]
		public string FXNGGFTAKZZ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DACE00", Offset = "0x8DAB400", VA = "0x188DACE00", Slot = "16")]
		public bool UJFYTXUIXCX(LRIABUPBGVB a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC580", Offset = "0x8DAAB80", VA = "0x188DAC580", Slot = "18")]
		public bool RNPDZOXGMQP(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA950", Offset = "0x8DA8F50", VA = "0x188DAA950")]
		private void IDYENAWNBEZ(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC560", Offset = "0x8DAAB60", VA = "0x188DAC560")]
		private bool PlayerHasRole(LRIABUPBGVB player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DADE90", Offset = "0x8DAC490", VA = "0x188DADE90")]
		private UCJNRTNWHRJ ZPEZXSMMOHR(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD780", Offset = "0x8DABD80", VA = "0x188DAD780")]
		internal AccountRoleType XFXCKBYPQLL(LRIABUPBGVB a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8B00", Offset = "0x8DA7100", VA = "0x188DA8B00")]
		private void BAISGUZXVWF(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC420", Offset = "0x8DAAA20", VA = "0x188DAC420", Slot = "11")]
		public IReadOnlyList<SWWZAYLJWPW> VSSPEGGQBGC(LRIABUPBGVB a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC420", Offset = "0x8DAAA20", VA = "0x188DAC420")]
		internal IReadOnlyList<UCJNRTNWHRJ> OAYFXKAKXFB(LRIABUPBGVB a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC250", Offset = "0x8DAA850", VA = "0x188DAC250")]
		internal IReadOnlyList<UCJNRTNWHRJ> MZPEVPGNKZZ(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA170", Offset = "0x8DA8770", VA = "0x188DAA170")]
		private void FSONFDVYDAM(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD4A0", Offset = "0x8DABAA0", VA = "0x188DAD4A0")]
		private static bool WNQIHIQCGSY(UCJNRTNWHRJ a, IReadOnlyDictionary<AccountRoleType, UCJNRTNWHRJ> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB430", Offset = "0x8DA9A30", VA = "0x188DAB430")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task KEFJHNNGHIK(QVELLFEGMYR a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, UCJNRTNWHRJ> c, LUVOEAWCUWK d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8C40", Offset = "0x8DA7240", VA = "0x188DA8C40")]
		[CompilerGenerated]
		internal static void BJRBLHPBYLR(Func<JLWDXOKAAZI, NCIYKWISPVH> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD130", Offset = "0x8DAB730", VA = "0x188DAD130")]
		[CompilerGenerated]
		internal static bool WJYYZEUZLSM(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface XQIBUGVZCUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool UDRLUTCHWNG(LRIABUPBGVB a, LRIABUPBGVB b, IEnumerable<LRIABUPBGVB> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string XUUBERZOHNL(VotekickFailReason a);
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
	internal class AGSCGVPKTQS : XQIBUGVZCUR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly KMZIONLGUAD JUACQLFNKPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly JKSGDRGBYUA VFXSTDIVGSK;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		[RecRoom.NoEngine.Common.Preserve]
		public AGSCGVPKTQS([Inject(null)] KMZIONLGUAD roomRoleManager, [Inject(null)] JKSGDRGBYUA gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4960", Offset = "0x8DA2F60", VA = "0x188DA4960")]
		private static PlayerEvent? YDHSGAAWTMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4760", Offset = "0x8DA2D60", VA = "0x188DA4760", Slot = "4")]
		public bool UDRLUTCHWNG(LRIABUPBGVB a, LRIABUPBGVB b, IEnumerable<LRIABUPBGVB> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4860", Offset = "0x8DA2E60", VA = "0x188DA4860", Slot = "5")]
		public string XUUBERZOHNL(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA49A0", Offset = "0x8DA2FA0", VA = "0x188DA49A0")]
		internal bool YWKVDCWIZSR(LRIABUPBGVB a, LRIABUPBGVB b, IEnumerable<LRIABUPBGVB> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
