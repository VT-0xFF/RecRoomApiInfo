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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA120610", Offset = "0xA11F010", VA = "0x18A120610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA126B70", Offset = "0xA125570", VA = "0x18A126B70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
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
	public delegate void OnRoomRoleUpdated(PPTCRKDFMWF player);
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
	public interface YDQRLCICTJF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool SAVMLFEOHNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool BUFXJXFDSTU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool JSACUQHMKPW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool ROJLAWAVPKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool INCVXXZLUVE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool LOAVXUWPGZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool QTIJDQVECZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class MECGDELTKKO
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
		public static readonly Guid XQREENWQJVY;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid EWHASHOUTOT;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid XNCDHUKFVYU;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid ZJTNDDVGEAE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid ROKKBKRXPRJ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid UDCAHMQIZXM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly KUEWOUQAZJZ<AccountRoleType, Guid> RHBSRFUJEUH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> FZVZGQCCMKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA1201A0", Offset = "0xA11EBA0", VA = "0x18A1201A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA120060", Offset = "0xA11EA60", VA = "0x18A120060")]
		public static AccountRoleType QIVREWWVRFD(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA11FF20", Offset = "0xA11E920", VA = "0x18A11FF20")]
		public static Guid DWHLVEXUVSJ(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA120220", Offset = "0xA11EC20", VA = "0x18A120220")]
		public static bool WBLVSOYZBWS(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA11FFC0", Offset = "0xA11E9C0", VA = "0x18A11FFC0")]
		public static bool JTVAXWQSJKC(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA11FEE0", Offset = "0xA11E8E0", VA = "0x18A11FEE0")]
		public static AccountRoleType BYWTJIZBWKZ(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1200F0", Offset = "0xA11EAF0", VA = "0x18A1200F0")]
		public static DEPRECATED_RoomRoleId STJWGLOFYCQ(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1202B0", Offset = "0xA11ECB0", VA = "0x18A1202B0")]
		internal static AccountRoleType WHTBZDKNGAD(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface OBCQLMYNNCD
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance LZIQRAZHRKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO OXKZEWFHELK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> EBEZJZUQQKC;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action GFAWMSTIEEI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType UTCLJGREOHA(PPTCRKDFMWF a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> ANZJBGNIPID(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task XDMRBCMVCHR(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task IXMSWCLQAKB(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<PPTCRKDFMWF> EUGWHKWHJUE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class FOIMWFFUJVX
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA119A60", Offset = "0xA118460", VA = "0x18A119A60")]
		public static AccountRoleType PTPNBXGFWGH(this OBCQLMYNNCD a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface GMVDKGCQKZX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		EXRPCRDOOVA KBITSQSCRDW
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated ZOQLADANMVS;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<GLELNBZYTDI> JWSTTDZUWTW(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GLELNBZYTDI KJVFBUXDEEC(PPTCRKDFMWF a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool INVDHXVYOGH(PPTCRKDFMWF a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<GLELNBZYTDI> SZENWIFIBDG(PPTCRKDFMWF a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ULEFKEMICQI(PPTCRKDFMWF a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GLELNBZYTDI VHFIWAFVZCF(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool TDPAHVZQOUX<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string BKEWIPSOOOJ(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YGXULAHDPTH(PPTCRKDFMWF a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface DOWUULPTPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task REPVHZEZYUN(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface MOZJXUQVPGM<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> MBKIMYTTNMX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? NFBKSHFLJFD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? PTSPVCSFIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA120690", Offset = "0xA11F090", VA = "0x18A120690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA120760", Offset = "0xA11F160", VA = "0x18A120760")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA120850", Offset = "0xA11F250", VA = "0x18A120850")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool CCJTOXJVQPR(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> YYSBJHRHEMZ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7528830", Offset = "0x7527230", VA = "0x187528830")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7527930", Offset = "0x7526330", VA = "0x187527930", Slot = "4")]
		public override bool CCJTOXJVQPR(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7528300", Offset = "0x7526D00", VA = "0x187528300")]
		public bool JZEUBAXIFPV(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7528960", Offset = "0x7527360", VA = "0x187528960")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class WEEQAJLFXOY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> MYWSRILZGVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> RPOXWIGWORN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly TDOUKSWFNXR VZORKVSYTKT;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA126710", Offset = "0xA125110", VA = "0x18A126710")]
		public WEEQAJLFXOY(TDOUKSWFNXR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA1263F0", Offset = "0xA124DF0", VA = "0x18A1263F0")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40FAB90", Offset = "0x40F9590", VA = "0x1840FAB90")]
		public bool KOBIKQPNDEV<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40FA460", Offset = "0x40F8E60", VA = "0x1840FA460")]
		public (bool, a?) EPYDWCOIAVD<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA126310", Offset = "0xA124D10", VA = "0x18A126310")]
		public bool KOBIKQPNDEV(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA126190", Offset = "0xA124B90", VA = "0x18A126190")]
		public (bool, object) EPYDWCOIAVD(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x40FB350", Offset = "0x40F9D50", VA = "0x1840FB350")]
		private void UIYEWYCFSDQ<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA126640", Offset = "0xA125040", VA = "0x18A126640")]
		private Permission WUIFZPSVBOQ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA126460", Offset = "0xA124E60", VA = "0x18A126460")]
		public void QTXSZKQUYDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class XIJFEQQOWRV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string TXCGYKEAUJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type VNQXOCWPOAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType IZQYSULZCUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission DIBOOYYDPKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet LEIYQWFJBCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue LQSAHZLUZLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission HGENGYUWFZC;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA126AA0", Offset = "0xA1254A0", VA = "0x18A126AA0")]
		public XIJFEQQOWRV(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1269A0", Offset = "0xA1253A0", VA = "0x18A1269A0")]
		public object OZJEVYDEKTT(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x410FF20", Offset = "0x410E920", VA = "0x18410FF20")]
		public void UIYEWYCFSDQ<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA1269F0", Offset = "0xA1253F0", VA = "0x18A1269F0")]
		public void UIYEWYCFSDQ(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class SVOZBSURVOE<a> : XIJFEQQOWRV where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet VCSUFVJNGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue RGWWFMPESUZ;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7EF88A0", Offset = "0x7EF72A0", VA = "0x187EF88A0")]
			internal string VLEOADDJXDS(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8F50", Offset = "0x7EF7950", VA = "0x187EF8F50")]
			internal object VLJUXJXHGPB(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x79D8780", Offset = "0x79D7180", VA = "0x1879D8780")]
		public SVOZBSURVOE(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x79D7A80", Offset = "0x79D6480", VA = "0x1879D7A80")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79D8070", Offset = "0x79D6A70", VA = "0x1879D8070")]
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
	internal class TDOUKSWFNXR
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class AEIRTDHGKLX : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static AEIRTDHGKLX LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA117790", Offset = "0xA116190", VA = "0x18A117790", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA1178E0", Offset = "0xA1162E0", VA = "0x18A1178E0", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public AEIRTDHGKLX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class ILSELPWKEKP : UDKPKAVGNYS<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA119CA0", Offset = "0xA1186A0", VA = "0x18A119CA0", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA119D90", Offset = "0xA118790", VA = "0x18A119D90", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA119F40", Offset = "0xA118940", VA = "0x18A119F40")]
			public ILSELPWKEKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly HIQWKOJHAHG LRUYLBXMPLW;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly ILSELPWKEKP MOBYKWOMMZZ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<XIJFEQQOWRV> UKDWZXGUQVU;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> HIEQVVFNZDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, XIJFEQQOWRV> BSWRNSOEPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA123300", Offset = "0xA121D00", VA = "0x18A123300")]
		public TDOUKSWFNXR([Optional] IList<XIJFEQQOWRV>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA121420", Offset = "0xA11FE20", VA = "0x18A121420")]
		public XIJFEQQOWRV VHDKAXSTCPQ(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface EXRPCRDOOVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		GLELNBZYTDI MHENQEWUNCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class VAWTPQFDYMP : EXRPCRDOOVA
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static VAWTPQFDYMP ZMDRZLIKGJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly BXNHPNPKPEN POBCSLHTQFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<BXNHPNPKPEN> FRVNGMNOVGS;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public GLELNBZYTDI MHENQEWUNCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA126090", Offset = "0xA124A90", VA = "0x18A126090")]
		public VAWTPQFDYMP(BXNHPNPKPEN a, IReadOnlyList<BXNHPNPKPEN> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA124FA0", Offset = "0xA1239A0", VA = "0x18A124FA0")]
		private static VAWTPQFDYMP LHPXBZGDEPO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class RGSZAPCNJER
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA121170", Offset = "0xA11FB70", VA = "0x18A121170")]
		public static OFZZDEODIOB XTZRXNUOUQB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class DIDFKYAZOBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> ELTZTPHJQYV;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA119760", Offset = "0xA118160", VA = "0x18A119760")]
		public static bool APBNLVDWIOJ(this PPTCRKDFMWF a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA119840", Offset = "0xA118240", VA = "0x18A119840")]
		public static bool CHGYXVFIHOG(this PPTCRKDFMWF a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface UNDAWARGKSL
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> VGYDWPCCIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType PVXQPZWFBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface GLELNBZYTDI : UNDAWARGKSL, YDQRLCICTJF, MOZJXUQVPGM<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string WYBYIPAAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType FHJIJIEGASZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) JUGBQWVQOPJ<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class BXNHPNPKPEN : GLELNBZYTDI, UNDAWARGKSL, YDQRLCICTJF, MOZJXUQVPGM<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly TDOUKSWFNXR TDOUKSWFNXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly WEEQAJLFXOY ALEHRBHHWDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? DLHMYFWAERT;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool LICIFKEPSAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA117C00", Offset = "0xA116600", VA = "0x18A117C00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool LPXCPKDHHGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA118050", Offset = "0xA116A50", VA = "0x18A118050", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool EEFSQJHSOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA1180A0", Offset = "0xA116AA0", VA = "0x18A1180A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool ATWKHITQIGV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA1180F0", Offset = "0xA116AF0", VA = "0x18A1180F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool GLPFDUUMBAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA119250", Offset = "0xA117C50", VA = "0x18A119250", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool HKMEWFCESSA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA1192A0", Offset = "0xA117CA0", VA = "0x18A1192A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool SZCVOJOUIXI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA1190A0", Offset = "0xA117AA0", VA = "0x18A1190A0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType FHJIJIEGASZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x88CDBD0", Offset = "0x88CC5D0", VA = "0x1888CDBD0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string WYBYIPAAAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x88CDBD0", Offset = "0x88CC5D0", VA = "0x1888CDBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ZRFPKPPNYXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD2F810", Offset = "0xD2E210", VA = "0x180D2F810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD300E0", Offset = "0xD2EAE0", VA = "0x180D300E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType PVXQPZWFBLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA117BB0", Offset = "0xA1165B0", VA = "0x18A117BB0", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> VGYDWPCCIHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA1192F0", Offset = "0xA117CF0", VA = "0x18A1192F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool ZTEPDKAFTHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA117C00", Offset = "0xA116600", VA = "0x18A117C00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool SWWMCSAMGYX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA119250", Offset = "0xA117C50", VA = "0x18A119250", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HACESOVIYPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA118050", Offset = "0xA116A50", VA = "0x18A118050", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool SMUCGRXTLQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA1180A0", Offset = "0xA116AA0", VA = "0x18A1180A0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ZKOCRCMDQST
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA1180F0", Offset = "0xA116AF0", VA = "0x18A1180F0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool NGDGAQFUPZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA1192A0", Offset = "0xA117CA0", VA = "0x18A1192A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool XJHYCSSIUUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA1190A0", Offset = "0xA117AA0", VA = "0x18A1190A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> MBKIMYTTNMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA119110", Offset = "0xA117B10", VA = "0x18A119110", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA118D00", Offset = "0xA117700", VA = "0x18A118D00", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3728380", Offset = "0x3726D80", VA = "0x183728380", Slot = "6")]
		public (bool, a?) JUGBQWVQOPJ<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3728140", Offset = "0x3726B40", VA = "0x183728140")]
		public BXNHPNPKPEN HDVWONGAXCT<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA119720", Offset = "0xA118120", VA = "0x18A119720")]
		public BXNHPNPKPEN(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA119740", Offset = "0xA118140", VA = "0x18A119740")]
		public BXNHPNPKPEN(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA1196D0", Offset = "0xA1180D0", VA = "0x18A1196D0")]
		public BXNHPNPKPEN(BXNHPNPKPEN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA1195A0", Offset = "0xA117FA0", VA = "0x18A1195A0")]
		internal BXNHPNPKPEN(AccountRoleType a, [Optional] string? b, [Optional] BXNHPNPKPEN? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA118C80", Offset = "0xA117680", VA = "0x18A118C80")]
		public static RolePermissionType NVQZPUGMKWJ(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA1190F0", Offset = "0xA117AF0", VA = "0x18A1190F0")]
		public void QTXSZKQUYDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA118DB0", Offset = "0xA1177B0", VA = "0x18A118DB0")]
		internal BXNHPNPKPEN OBSRGQGWULN(BXNHPNPKPEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA117C50", Offset = "0xA116650", VA = "0x18A117C50")]
		internal IReadOnlyCollection<RolePermission> Copy(BXNHPNPKPEN roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA118140", Offset = "0xA116B40", VA = "0x18A118140")]
		public bool IRDGILPKPFY(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA118220", Offset = "0xA116C20", VA = "0x18A118220")]
		public (bool, string) KIFBHTABBVZ(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA118000", Offset = "0xA116A00", VA = "0x18A118000")]
		internal void EBDGYLMECOY(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA119350", Offset = "0xA117D50", VA = "0x18A119350")]
		public ZUPHRVQDGUY XWHIHLJHGIO(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA118320", Offset = "0xA116D20", VA = "0x18A118320")]
		public void LFNOVNXXFCG(ZUPHRVQDGUY a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA1191C0", Offset = "0xA117BC0", VA = "0x18A1191C0")]
		[CompilerGenerated]
		private void SDLOGCOUDTA(RolePermission a, NLYPSGQYUDR b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class IVRTZTMHEYG : DOWUULPTPOG, GMVDKGCQKZX, IDisposable, TSENLTSRTYN
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class XPLPZREOGEU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public BXNHPNPKPEN OGZDUSZKYKM;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XPLPZREOGEU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA126B40", Offset = "0xA125540", VA = "0x18A126B40")]
			internal bool OPKAOUTPGTG(BXNHPNPKPEN a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class ORXATKMALZB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType IRNOXFXBAAK;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ORXATKMALZB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1ED5200", Offset = "0x1ED3C00", VA = "0x181ED5200")]
			internal bool WDBDNTOTKQC(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class GVRQYAQNAEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder CNDIOAWLSIA;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public GVRQYAQNAEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA119BC0", Offset = "0xA1185C0", VA = "0x18A119BC0")]
			internal void CXGXIGYDUZZ(ZUPHRVQDGUY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA119AC0", Offset = "0xA1184C0", VA = "0x18A119AC0")]
			internal void CXBQLAEGLOQ(ZUPHRVQDGUY a)
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
		private sealed class LIAYBXXVJDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<ZUPHRVQDGUY, NLYPSGQYUDR> KIVGYOTCIMI;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public LIAYBXXVJDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA11FE50", Offset = "0xA11E850", VA = "0x18A11FE50")]
			internal void OLINWCTWLRS(ZUPHRVQDGUY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA11FEB0", Offset = "0xA11E8B0", VA = "0x18A11FEB0")]
			internal void OLYINXBONZT(ZUPHRVQDGUY a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA11FE80", Offset = "0xA11E880", VA = "0x18A11FE80")]
			internal void OLTBQQHREOK(ZUPHRVQDGUY a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class XINLFFDDOPP<a> where a : notnull
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
				public XINLFFDDOPP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x41D4C00", Offset = "0x41D3600", VA = "0x1841D4C00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0xD39FE0", Offset = "0xD389E0", VA = "0x180D39FE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission NOMLLVNLAXT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType EJDOBCJZUYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool YZTNXYYNYEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType FZFUVNRDMUM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string OJGIKFVQSCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public IVRTZTMHEYG IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action XXAYVFVMLWE;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XINLFFDDOPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x50A2E00", Offset = "0x50A1800", VA = "0x1850A2E00")]
			[AsyncStateMachine(typeof(XINLFFDDOPP<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void DXIKINKAYIO()
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
			public OBCQLMYNNCD rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, BXNHPNPKPEN> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public HDXKUQVKXSU debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA123630", Offset = "0xA122030", VA = "0x18A123630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xA124130", Offset = "0xA122B30", VA = "0x18A124130", Slot = "5")]
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
			public IVRTZTMHEYG <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA124190", Offset = "0xA122B90", VA = "0x18A124190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xA124800", Offset = "0xA123200", VA = "0x18A124800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly OBCQLMYNNCD NDTDBLLGEZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly VAWTPQFDYMP OMYCHMEMKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly HDXKUQVKXSU ZFXTZTGATJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private BGRHIWCMJRQ? PMAIMDJRMXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> JAGXIQAJZRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, BXNHPNPKPEN> LBSHGDUCVNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, BXNHPNPKPEN> UCBXISSKBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, BXNHPNPKPEN> HCYCYCNZSMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<BXNHPNPKPEN> QCWCHUYHALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool WGQQBAYUZZI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] EOOPQJMTZNA;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public EXRPCRDOOVA KBITSQSCRDW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated ZOQLADANMVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA11E020", Offset = "0xA11CA20", VA = "0x18A11E020", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA11F950", Offset = "0xA11E350", VA = "0x18A11F950", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA11B020", Offset = "0xA119A20", VA = "0x18A11B020")]
		[BQDQKYYGTTM.Room]
		internal static void BQDQKYYGTTM(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA11FBA0", Offset = "0xA11E5A0", VA = "0x18A11FBA0")]
		[UnityEngine.Scripting.Preserve]
		internal IVRTZTMHEYG([Inject(null)] OBCQLMYNNCD roleDataProvider, [Inject(null)] VAWTPQFDYMP roleManagerDefaults, [Inject(null)] HDXKUQVKXSU debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA11B4C0", Offset = "0xA119EC0", VA = "0x18A11B4C0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA11EAF0", Offset = "0xA11D4F0", VA = "0x18A11EAF0")]
		private void UWURVLHOUXA(IEnumerable<BXNHPNPKPEN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA11BC40", Offset = "0xA11A640", VA = "0x18A11BC40", Slot = "10")]
		public bool INVDHXVYOGH(PPTCRKDFMWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA11B630", Offset = "0xA11A030", VA = "0x18A11B630")]
		private void GFAWMSTIEEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA11B2E0", Offset = "0xA119CE0", VA = "0x18A11B2E0", Slot = "19")]
		public void DNNYQRJWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA11C0E0", Offset = "0xA11AAE0", VA = "0x18A11C0E0", Slot = "8")]
		public IReadOnlyList<GLELNBZYTDI> JWSTTDZUWTW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA11C160", Offset = "0xA11AB60", VA = "0x18A11C160", Slot = "9")]
		public GLELNBZYTDI KJVFBUXDEEC(PPTCRKDFMWF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA11C010", Offset = "0xA11AA10", VA = "0x18A11C010")]
		private AccountRoleType JVPLVZFBTJI(PPTCRKDFMWF a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA11EA30", Offset = "0xA11D430", VA = "0x18A11EA30", Slot = "12")]
		public bool ULEFKEMICQI(PPTCRKDFMWF a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA11F360", Offset = "0xA11DD60", VA = "0x18A11F360", Slot = "13")]
		public GLELNBZYTDI VHFIWAFVZCF(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA11C9E0", Offset = "0xA11B3E0", VA = "0x18A11C9E0")]
		private static bool LXXSGIJDSVU(OFZZDEODIOB a, AccountRoleType b, [Out] ZUPHRVQDGUY? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA11B8D0", Offset = "0xA11A2D0", VA = "0x18A11B8D0")]
		private static void HPUYAAHZEPS(OFZZDEODIOB a, Action<ZUPHRVQDGUY> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA11B640", Offset = "0xA11A040", VA = "0x18A11B640")]
		private static void HPUYAAHZEPS(OFZZDEODIOB a, Action<ZUPHRVQDGUY> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA11B5C0", Offset = "0xA119FC0", VA = "0x18A11B5C0")]
		private void FNSTZCOWSHL(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA11D4F0", Offset = "0xA11BEF0", VA = "0x18A11D4F0", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task REPVHZEZYUN([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA11CE50", Offset = "0xA11B850", VA = "0x18A11CE50")]
		private void OHEOVKBNPKF(OFZZDEODIOB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA11BD10", Offset = "0xA11A710", VA = "0x18A11BD10")]
		internal static string JIJKJLSWEQP(OBCQLMYNNCD a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, BXNHPNPKPEN> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA119F80", Offset = "0xA118980", VA = "0x18A119F80")]
		private static void ACZLNPSFSDB(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA11F610", Offset = "0xA11E010", VA = "0x18A11F610")]
		private static void ZEIQCRGMEBW(OFZZDEODIOB a, IReadOnlyDictionary<AccountRoleType, BXNHPNPKPEN> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA11B1D0", Offset = "0xA119BD0", VA = "0x18A11B1D0")]
		private static bool CFZNABSACRB(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA11C2C0", Offset = "0xA11ACC0", VA = "0x18A11C2C0")]
		private static void LHTKBIICRQA(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B345C0", Offset = "0x3B32FC0", VA = "0x183B345C0", Slot = "14")]
		public bool TDPAHVZQOUX<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA11AFA0", Offset = "0xA1199A0", VA = "0x18A11AFA0", Slot = "15")]
		public string BKEWIPSOOOJ(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA11F400", Offset = "0xA11DE00", VA = "0x18A11F400", Slot = "16")]
		public bool YGXULAHDPTH(PPTCRKDFMWF a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA11D430", Offset = "0xA11BE30", VA = "0x18A11D430", Slot = "18")]
		public bool RCKLUPOGTOJ(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA11AD20", Offset = "0xA119720", VA = "0x18A11AD20")]
		private void ADROIUAVVLR(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA11D410", Offset = "0xA11BE10", VA = "0x18A11D410")]
		private bool PlayerHasRole(PPTCRKDFMWF player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA11D180", Offset = "0xA11BB80", VA = "0x18A11D180")]
		private BXNHPNPKPEN OJICOZXHMCJ(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA11B9C0", Offset = "0xA11A3C0", VA = "0x18A11B9C0")]
		internal AccountRoleType IELSOALLCRJ(PPTCRKDFMWF a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA11CD10", Offset = "0xA11B710", VA = "0x18A11CD10")]
		private void NCBRMTRYZSP(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA11AF20", Offset = "0xA119920", VA = "0x18A11AF20", Slot = "11")]
		public IReadOnlyList<GLELNBZYTDI> SZENWIFIBDG(PPTCRKDFMWF a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA11AF20", Offset = "0xA119920", VA = "0x18A11AF20")]
		internal IReadOnlyList<BXNHPNPKPEN> AEIKCFNRDFD(PPTCRKDFMWF a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA11E860", Offset = "0xA11D260", VA = "0x18A11E860")]
		internal IReadOnlyList<BXNHPNPKPEN> UBVGLRSWWDP(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA11D610", Offset = "0xA11C010", VA = "0x18A11D610")]
		private void RRWHSKFGONM(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA11E0C0", Offset = "0xA11CAC0", VA = "0x18A11E0C0")]
		private static bool SWGQQONUQDM(BXNHPNPKPEN a, IReadOnlyDictionary<AccountRoleType, BXNHPNPKPEN> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA11E720", Offset = "0xA11D120", VA = "0x18A11E720")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task TRACJYBXWQI(OBCQLMYNNCD a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, BXNHPNPKPEN> c, HDXKUQVKXSU d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA11DD90", Offset = "0xA11C790", VA = "0x18A11DD90")]
		[CompilerGenerated]
		internal static void RUUOHRAYMNH(Func<ZUPHRVQDGUY, NLYPSGQYUDR> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA11E3B0", Offset = "0xA11CDB0", VA = "0x18A11E3B0")]
		[CompilerGenerated]
		internal static bool TDBVWIIRLLQ(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface LLTGEFWWZMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool DSMQIJBUOGK(PPTCRKDFMWF a, PPTCRKDFMWF b, IEnumerable<PPTCRKDFMWF> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string SXOTHFZOHNN(VotekickFailReason a);
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
	internal class QYEFAYUZHGM : LLTGEFWWZMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly GMVDKGCQKZX AUHSKOLRZBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly WGXKWGPZZSG GHRIEATQZZK;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		[RecRoom.NoEngine.Common.Preserve]
		public QYEFAYUZHGM([Inject(null)] GMVDKGCQKZX roomRoleManager, [Inject(null)] WGXKWGPZZSG gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA121030", Offset = "0xA11FA30", VA = "0x18A121030")]
		private static PlayerEvent? QARJPRTPRCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA120940", Offset = "0xA11F340", VA = "0x18A120940", Slot = "4")]
		public bool DSMQIJBUOGK(PPTCRKDFMWF a, PPTCRKDFMWF b, IEnumerable<PPTCRKDFMWF> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA121070", Offset = "0xA11FA70", VA = "0x18A121070", Slot = "5")]
		public string SXOTHFZOHNN(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA120A40", Offset = "0xA11F440", VA = "0x18A120A40")]
		internal bool ETDDEOGWLFF(PPTCRKDFMWF a, PPTCRKDFMWF b, IEnumerable<PPTCRKDFMWF> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
