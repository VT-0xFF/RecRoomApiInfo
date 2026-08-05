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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ADC1E0", Offset = "0x8ADA9E0", VA = "0x188ADC1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE21C0", Offset = "0x8AE09C0", VA = "0x188AE21C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
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
	public delegate void OnRoomRoleUpdated(RHIZVYSCBOY player);
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
	public interface IGOTMEHALBE
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool NRMZMSUASRN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool MAYOQGBSSUP
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool BLMMHNMVKGD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool OEYLNVMLKLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool TOSAZEZYACZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool AHETNMHLBSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool BBXRIKRJSFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class RPXLKNKVLKB
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
		public static readonly Guid UNQNIZOYYXB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly Guid GGASRJQIKCE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly Guid RUILMWJJWUD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly Guid VHGMDBNMDDN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly Guid DCVRQVMKVPU;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Guid CCPRPRORWSB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly WZQYDZQAXYA<AccountRoleType, Guid> OGLPOSKYWRW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		internal static IEnumerable<AccountRoleType> HZFYEVERLTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCC20", Offset = "0x8ADB420", VA = "0x188ADCC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCE10", Offset = "0x8ADB610", VA = "0x188ADCE10")]
		public static AccountRoleType RDGKWQOOPIK(Guid a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCAE0", Offset = "0x8ADB2E0", VA = "0x188ADCAE0")]
		public static Guid ATDYAYAPYHI(AccountRoleType a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCCD0", Offset = "0x8ADB4D0", VA = "0x188ADCCD0")]
		public static bool MKVCRVKVCUL(AccountRoleType a, [Out] Guid b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCB80", Offset = "0x8ADB380", VA = "0x188ADCB80")]
		public static bool CIESIQXPJUX(Guid a, [Out] AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCEA0", Offset = "0x8ADB6A0", VA = "0x188ADCEA0")]
		public static AccountRoleType WABKEUPDJAY(AccountRoleType a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCD60", Offset = "0x8ADB560", VA = "0x188ADCD60")]
		public static DEPRECATED_RoomRoleId NVQCTTKXZFN(AccountRoleType a)
		{
			return default(DEPRECATED_RoomRoleId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCC90", Offset = "0x8ADB490", VA = "0x188ADCC90")]
		internal static AccountRoleType JXUDFOHTAOC(DEPRECATED_RoomRoleId a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface VIILDPRAETI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		RHIZVYSCBOY PMVKNQAWXFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RoomInstance FALOXBECPGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RoomDetailsDTO KSHLKDXSOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<PhotonAccessTokenAndPermissionsDTO> IPDDHBAWCSX;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action VRMBLZSQHLL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AccountRoleType TGWIBRQOWVV(RHIZVYSCBOY a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<PhotonAccessTokenAndPermissionsDTO> SDPKNVJGIAW(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task HEKKBWSIVBO(long a, IReadOnlyList<RolePermissionDTO> b);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task FPXJKHYXQJO(long a, long b, IReadOnlyList<RolePermissionDTO> c);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IEnumerable<RHIZVYSCBOY> QPLJBXUQODL();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class EIGNYKHURVC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9B80", Offset = "0x8AD8380", VA = "0x188AD9B80")]
		public static AccountRoleType GHNHZDCTCNS(this VIILDPRAETI a)
		{
			return default(AccountRoleType);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface BULGXLLDMCM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		EKUUNKYENOH DUIJBIDIQAF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event OnRoomRoleUpdated QAHKZEKSOSN;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<LDUVSNDRGQJ> HXYXGVZKMEP(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		LDUVSNDRGQJ LTKHWKYJPXP(RHIZVYSCBOY a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QGKXVHKQAWC(RHIZVYSCBOY a);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<LDUVSNDRGQJ> PEPUDDZKLBR(RHIZVYSCBOY a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LIEOBWOOYKD(RHIZVYSCBOY a, AccountRoleType b);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LDUVSNDRGQJ UHRUSKTNQOW(AccountRoleType a);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GKGPDSWKWHI<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string MDSKPBYJIAC(RolePermission a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool EBFBDXYIGZE(RHIZVYSCBOY a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MZXHOIOPRLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task NWWHPUUPOSA(PersistedRoomData a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CEBAFVCGQZR<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event OnRolePermissionUpdated<a> DWKWKAWVEGA;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal abstract class Permission
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal object? VDJUAHWWWNW;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object? DPCIHLEFFZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8ADC810", Offset = "0x8ADB010", VA = "0x188ADC810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8ADC8E0", Offset = "0x8ADB0E0", VA = "0x188ADC8E0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC9E0", Offset = "0x8ADB1E0", VA = "0x188ADC9E0")]
		protected Permission(object? objectValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool DVKRAOKHAYW(object? a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class Permission<T> : Permission where T : notnull, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IEqualityComparer<T> QCKOAHFNEEE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5B379A0", Offset = "0x5B361A0", VA = "0x185B379A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5B37220", Offset = "0x5B35A20", VA = "0x185B37220", Slot = "4")]
		public override bool DVKRAOKHAYW(object? a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B37A80", Offset = "0x5B36280", VA = "0x185B37A80")]
		public bool VWAPIWKUTJG(T a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B38100", Offset = "0x5B36900", VA = "0x185B38100")]
		public Permission(T defaultValue, IEqualityComparer<T> equalityComparer)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class MATPUZQTPDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<RolePermission, bool> MQNBMMPDLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<RolePermission, Permission> JKGMYUMBPVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly SZMMUBXIUMO JPNJKSMTDQC;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBF50", Offset = "0x8ADA750", VA = "0x188ADBF50")]
		public MATPUZQTPDP(SZMMUBXIUMO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD50", Offset = "0x8ADA550", VA = "0x188ADBD50")]
		public bool Overrides(RolePermission rolePermission)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x376C710", Offset = "0x376AF10", VA = "0x18376C710")]
		public bool JCNBZLAIXJY<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x376CFA0", Offset = "0x376B7A0", VA = "0x18376CFA0")]
		public (bool, a?) VWUHXEBEUFI<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBC70", Offset = "0x8ADA470", VA = "0x188ADBC70")]
		public bool JCNBZLAIXJY(RolePermission a, bool b, object c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBDC0", Offset = "0x8ADA5C0", VA = "0x188ADBDC0")]
		public (bool, object) VWUHXEBEUFI(RolePermission a)
		{
			return default((bool, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x376CEC0", Offset = "0x376B6C0", VA = "0x18376CEC0")]
		private void PIAJCCYGKQB<b>(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB9C0", Offset = "0x8ADA1C0", VA = "0x188ADB9C0")]
		private Permission BGETCCGUMJV(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBA90", Offset = "0x8ADA290", VA = "0x188ADBA90")]
		public void EOGLFGFJMLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class OHGDQWKXTDW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly string RGSTDJSUNUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Type VFYSWSORXBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly RolePermissionType FCWJUVOUVUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public readonly RolePermission WWCUEQQPCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public SerializeValueForRecNet PQEIAGMRZHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DeserializeRecNetValue WFBVHFHSJLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public ConstructPermission ZKORMYWIKPV;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC360", Offset = "0x8ADAB60", VA = "0x188ADC360")]
		public OHGDQWKXTDW(Type a, string b, RolePermission c, SerializeValueForRecNet d, DeserializeRecNetValue e, ConstructPermission f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC310", Offset = "0x8ADAB10", VA = "0x188ADC310")]
		public object YYDNDDPHIUM(object? other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38895D0", Offset = "0x3887DD0", VA = "0x1838895D0")]
		public void PIAJCCYGKQB<a>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC260", Offset = "0x8ADAA60", VA = "0x188ADC260")]
		public void PIAJCCYGKQB(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class TMAFMRWFZYP<a> : OHGDQWKXTDW where a : new()
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal delegate string SerializeValueForRecNet(a value);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		internal delegate a DeserializeRecNetValue(string? serializedValue, a defaultValue);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public SerializeValueForRecNet OMMUOCUZGSH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DeserializeRecNetValue CCXDUTXEEVU;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4DDE7E0", Offset = "0x4DDCFE0", VA = "0x184DDE7E0")]
			internal string IEPWQYBNDHN(object? v)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4DDE460", Offset = "0x4DDCC60", VA = "0x184DDE460")]
			internal object IEKPTRHPTWE(string? s, object a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5F0FA90", Offset = "0x5F0E290", VA = "0x185F0FA90")]
		public TMAFMRWFZYP(RolePermission a, string b, [Optional] SerializeValueForRecNet? serializeRecNetString, [Optional] DeserializeRecNetValue? parseRecNetString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5F0E410", Offset = "0x5F0CC10", VA = "0x185F0E410")]
		private static object? Deserialize(DeserializeRecNetValue? parseRecNetString, string? serializedValue, object? defaultValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F0F0A0", Offset = "0x5F0D8A0", VA = "0x185F0F0A0")]
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
	internal class SZMMUBXIUMO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private class PMIOJUPKSGI : IEqualityComparer<List<string>>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			internal static PMIOJUPKSGI GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8ADC400", Offset = "0x8ADAC00", VA = "0x188ADC400", Slot = "4")]
			public bool Equals(List<string> x, List<string> y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8ADC550", Offset = "0x8ADAD50", VA = "0x188ADC550", Slot = "5")]
			public int GetHashCode(List<string> obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PMIOJUPKSGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private class UDXBZAFTSBM : XWEVTJFRHOH<VotekickType>
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8AE0D00", Offset = "0x8ADF500", VA = "0x188AE0D00", Slot = "9")]
			public override string Serialize(VotekickType input)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE0DF0", Offset = "0x8ADF5F0", VA = "0x188AE0DF0", Slot = "10")]
			protected override bool TryParseInternal(string input, [Out] VotekickType value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE0FA0", Offset = "0x8ADF7A0", VA = "0x188AE0FA0")]
			public UDXBZAFTSBM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly EBRODCLGBGF BSLFTQIRHVP;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly UDXBZAFTSBM WOPJRUJOJFQ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly List<OHGDQWKXTDW> BWEFCOFCLQH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IEnumerable<RolePermission> IMFEVGQZMPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyDictionary<RolePermission, OHGDQWKXTDW> YUQVFPWYYZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF080", Offset = "0x8ADD880", VA = "0x188ADF080")]
		public SZMMUBXIUMO([Optional] IList<OHGDQWKXTDW>? fieldDescriptors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD1D0", Offset = "0x8ADB9D0", VA = "0x188ADD1D0")]
		public OHGDQWKXTDW CRULMLYAZGP(RolePermission a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface EKUUNKYENOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		LDUVSNDRGQJ BRVSACBUXHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class UHILGCGFMAY : EKUUNKYENOH
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static UHILGCGFMAY MPQFHIUQEWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal readonly ILYAEWXMVBO YWURPTGONJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal readonly IReadOnlyList<ILYAEWXMVBO> YGXONCJHJVR;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public LDUVSNDRGQJ BRVSACBUXHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8AE20C0", Offset = "0x8AE08C0", VA = "0x188AE20C0")]
		public UHILGCGFMAY(ILYAEWXMVBO a, IReadOnlyList<ILYAEWXMVBO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0FE0", Offset = "0x8ADF7E0", VA = "0x188AE0FE0")]
		private static UHILGCGFMAY FRWHPXIWUUH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class BFPNJBRIDRZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly IReadOnlyList<AccountRoleType> AIIBMCAORVE;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3AB0", Offset = "0x8AD22B0", VA = "0x188AD3AB0")]
		public static bool EDGGASNXUVW(this RHIZVYSCBOY a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3B90", Offset = "0x8AD2390", VA = "0x188AD3B90")]
		public static bool LTYVUWQHHPL(this RHIZVYSCBOY a, AccountRoleType b, RoomDetailsDTO c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface YWHVORRZXJE
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IReadOnlyList<string> DIJEHIYEVNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		VotekickType TEBQNDKCBGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface LDUVSNDRGQJ : YWHVORRZXJE, IGOTMEHALBE, CEBAFVCGQZR<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		string ZWUIWROFCTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AccountRoleType HGBTSLBNVYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, a?) OSYHUXVJIFK<a>(RolePermission a) where a : new();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal class ILYAEWXMVBO : LDUVSNDRGQJ, YWHVORRZXJE, IGOTMEHALBE, CEBAFVCGQZR<RolePermission>
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		internal static readonly SZMMUBXIUMO SZMMUBXIUMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		internal readonly MATPUZQTPDP QYXMPTIWWRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string? SUARNRKQBGU;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private bool IYYDDBNSPUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA420", Offset = "0x8AD8C20", VA = "0x188ADA420", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool ZXMIZXMBLJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA490", Offset = "0x8AD8C90", VA = "0x188ADA490", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private bool KKADLYAOZFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9F10", Offset = "0x8AD8710", VA = "0x188AD9F10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool PKKCQVTAIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA4E0", Offset = "0x8AD8CE0", VA = "0x188ADA4E0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private bool TUSSURPDWYS
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA530", Offset = "0x8AD8D30", VA = "0x188ADA530", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private bool IRGYRPEBHUR
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9C70", Offset = "0x8AD8470", VA = "0x188AD9C70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private bool JYLKRXZRWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA9F0", Offset = "0x8AD91F0", VA = "0x188ADA9F0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AccountRoleType HGBTSLBNVYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(AccountRoleType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA2A00", Offset = "0xAA1200", VA = "0x180AA2A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RoleName
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x732C1B0", Offset = "0x732A9B0", VA = "0x18732C1B0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string ZWUIWROFCTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x732C1B0", Offset = "0x732A9B0", VA = "0x18732C1B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool WYGFPWZUPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public VotekickType TEBQNDKCBGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA660", Offset = "0x8AD8E60", VA = "0x188ADA660", Slot = "8")]
			get
			{
				return default(VotekickType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> DIJEHIYEVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9F60", Offset = "0x8AD8760", VA = "0x188AD9F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool JGTEITAFECZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA420", Offset = "0x8AD8C20", VA = "0x188ADA420", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BQTJIRVDFQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA530", Offset = "0x8AD8D30", VA = "0x188ADA530", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool EXSXCPLCRLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA490", Offset = "0x8AD8C90", VA = "0x188ADA490", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool WEFGZWKZQCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9F10", Offset = "0x8AD8710", VA = "0x188AD9F10", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool HNEGKSJCWVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA4E0", Offset = "0x8AD8CE0", VA = "0x188ADA4E0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool NCFKOIIKVYX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9C70", Offset = "0x8AD8470", VA = "0x188AD9C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool WOUBXGXAVRF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA9F0", Offset = "0x8AD91F0", VA = "0x188ADA9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OnRolePermissionUpdated<RolePermission> DWKWKAWVEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8ADA370", Offset = "0x8AD8B70", VA = "0x188ADA370", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB410", Offset = "0x8AD9C10", VA = "0x188ADB410", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x36EF5E0", Offset = "0x36EDDE0", VA = "0x1836EF5E0", Slot = "6")]
		public (bool, a?) OSYHUXVJIFK<a>(RolePermission a) where a : new()
		{
			return default((bool, a));
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x36EFAC0", Offset = "0x36EE2C0", VA = "0x1836EFAC0")]
		public ILYAEWXMVBO SNYPVGQENWI<T>(RolePermission a, bool b, T c) where T : notnull, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB7A0", Offset = "0x8AD9FA0", VA = "0x188ADB7A0")]
		public ILYAEWXMVBO(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB7C0", Offset = "0x8AD9FC0", VA = "0x188ADB7C0")]
		public ILYAEWXMVBO(AccountRoleType a, [Optional] string? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB630", Offset = "0x8AD9E30", VA = "0x188ADB630")]
		public ILYAEWXMVBO(ILYAEWXMVBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB680", Offset = "0x8AD9E80", VA = "0x188ADB680")]
		internal ILYAEWXMVBO(AccountRoleType a, [Optional] string? b, [Optional] ILYAEWXMVBO? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAA40", Offset = "0x8AD9240", VA = "0x188ADAA40")]
		public static RolePermissionType TSRREWPGKCO(RolePermission a)
		{
			return default(RolePermissionType);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA470", Offset = "0x8AD8C70", VA = "0x188ADA470")]
		public void EOGLFGFJMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA6B0", Offset = "0x8AD8EB0", VA = "0x188ADA6B0")]
		internal ILYAEWXMVBO NEHDSNIMHLC(ILYAEWXMVBO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9FC0", Offset = "0x8AD87C0", VA = "0x188AD9FC0")]
		internal IReadOnlyCollection<RolePermission> Copy(ILYAEWXMVBO roleToCopy)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA580", Offset = "0x8AD8D80", VA = "0x188ADA580")]
		public bool KQJTVFTJKIF(RolePermission a, bool b, string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB4C0", Offset = "0x8AD9CC0", VA = "0x188ADB4C0")]
		public (bool, string) YMDDXLCOZTK(RolePermission a)
		{
			return default((bool, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA9A0", Offset = "0x8AD91A0", VA = "0x188ADA9A0")]
		internal void NOSMVPXBDOX(RolePermission a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9D50", Offset = "0x8AD8550", VA = "0x188AD9D50")]
		public GTHGDLCZRLT BFCKLVAPQTH(Func<AccountRoleType, Guid> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAAB0", Offset = "0x8AD92B0", VA = "0x188ADAAB0")]
		public void VKUHAZRKKZT(GTHGDLCZRLT a, Func<Guid, AccountRoleType> b, [Optional] AccountRoleType? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9CC0", Offset = "0x8AD84C0", VA = "0x188AD9CC0")]
		[CompilerGenerated]
		private void APOETYENOOH(RolePermission a, SHAIKNYIWKI b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class BQATGGMTQAN : MZXHOIOPRLH, BULGXLLDMCM, IDisposable, DHZPZFANTTG
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class BXAPWFAQUBV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ILYAEWXMVBO JJBHXFNOIMP;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BXAPWFAQUBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9B50", Offset = "0x8AD8350", VA = "0x188AD9B50")]
			internal bool NWJDFIZYNMJ(ILYAEWXMVBO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class EQQHSUUAGWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AccountRoleType ZLQUFHWDFVV;

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public EQQHSUUAGWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1CBA7B0", Offset = "0x1CB8FB0", VA = "0x181CBA7B0")]
			internal bool KVKXFVLXNYR(AccountRoleType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class KJQCFSOLMES
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public StringBuilder VJRHVEZNCKP;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KJQCFSOLMES()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB7E0", Offset = "0x8AD9FE0", VA = "0x188ADB7E0")]
			internal void QUTPTOJZLGC(GTHGDLCZRLT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB8C0", Offset = "0x8ADA0C0", VA = "0x188ADB8C0")]
			internal void QUYWQVDWURL(GTHGDLCZRLT a)
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
		private sealed class FXGVBVHDDFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<GTHGDLCZRLT, SHAIKNYIWKI> HXWZBDSVGQR;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FXGVBVHDDFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9BE0", Offset = "0x8AD83E0", VA = "0x188AD9BE0")]
			internal void EFAQFOLBDAX(GTHGDLCZRLT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9C10", Offset = "0x8AD8410", VA = "0x188AD9C10")]
			internal void EFFXCVEYMMG(GTHGDLCZRLT a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8AD9C40", Offset = "0x8AD8440", VA = "0x188AD9C40")]
			internal void EFLEABYVVXP(GTHGDLCZRLT a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class ASISFIUAMHQ<a> where a : notnull
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
				public ASISFIUAMHQ<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				private TaskAwaiter<PhotonAccessTokenAndPermissionsDTO> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x3C9C4E0", Offset = "0x3C9ACE0", VA = "0x183C9C4E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xAFF690", Offset = "0xAFDE90", VA = "0x180AFF690", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public RolePermission QUHMVSSNTFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AccountRoleType TDUOFVQOHGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool VQTGILMXSXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RolePermissionType AHCXGXQZVOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string QXBBYNPBLZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public BQATGGMTQAN VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public Action GIELYXIWRRH;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ASISFIUAMHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x536A820", Offset = "0x5369020", VA = "0x18536A820")]
			[AsyncStateMachine(typeof(ASISFIUAMHQ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
			internal void DQEEQMGMYKR()
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
			public VIILDPRAETI rolesDataProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public PersistedRoomData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public IReadOnlyDictionary<AccountRoleType, ILYAEWXMVBO> defaultRoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ZYRTIIHIZWB debugLogger;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8ADF390", Offset = "0x8ADDB90", VA = "0x188ADF390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFE90", Offset = "0x8ADE690", VA = "0x188ADFE90", Slot = "5")]
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
			public BQATGGMTQAN <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8ADFEF0", Offset = "0x8ADE6F0", VA = "0x188ADFEF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8AE0560", Offset = "0x8ADED60", VA = "0x188AE0560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DependsOn]
		private readonly VIILDPRAETI ZCIHUOHNSYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private readonly UHILGCGFMAY ULZLUYELXGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DependsOn]
		private readonly ZYRTIIHIZWB CKJIVMSQSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KGEQIOBDIXP? MTBUNJGMDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<int, AccountRoleType> VPYVXPSLWNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<AccountRoleType, ILYAEWXMVBO> SHEVNZAMKTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal readonly Dictionary<AccountRoleType, ILYAEWXMVBO> QHNSTOLOOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly Dictionary<AccountRoleType, ILYAEWXMVBO> YOYMSQROABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly List<ILYAEWXMVBO> PFGKNAESPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool MJFDXVHBTWZ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly RolePermission[] ZPJQVIFZVRD;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public EKUUNKYENOH DUIJBIDIQAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OnRoomRoleUpdated QAHKZEKSOSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4EB0", Offset = "0x8AD36B0", VA = "0x188AD4EB0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7670", Offset = "0x8AD5E70", VA = "0x188AD7670", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8F80", Offset = "0x8AD7780", VA = "0x188AD8F80")]
		[UKOBXVXKPZF.Room]
		internal static void UKOBXVXKPZF(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8AD98A0", Offset = "0x8AD80A0", VA = "0x188AD98A0")]
		[UnityEngine.Scripting.Preserve]
		internal BQATGGMTQAN([Inject(null)] VIILDPRAETI roleDataProvider, [Inject(null)] UHILGCGFMAY roleManagerDefaults, [Inject(null)] ZYRTIIHIZWB debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3FE0", Offset = "0x8AD27E0", VA = "0x188AD3FE0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5250", Offset = "0x8AD3A50", VA = "0x188AD5250")]
		private void KBPWCUEYNYT(IEnumerable<ILYAEWXMVBO> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7270", Offset = "0x8AD5A70", VA = "0x188AD7270", Slot = "10")]
		public bool QGKXVHKQAWC(RHIZVYSCBOY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9120", Offset = "0x8AD7920", VA = "0x188AD9120")]
		private void VRMBLZSQHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9520", Offset = "0x8AD7D20", VA = "0x188AD9520", Slot = "19")]
		public void ZIMEZOYLMVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4F50", Offset = "0x8AD3750", VA = "0x188AD4F50", Slot = "8")]
		public IReadOnlyList<LDUVSNDRGQJ> HXYXGVZKMEP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5B70", Offset = "0x8AD4370", VA = "0x188AD5B70", Slot = "9")]
		public LDUVSNDRGQJ LTKHWKYJPXP(RHIZVYSCBOY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4670", Offset = "0x8AD2E70", VA = "0x188AD4670")]
		private AccountRoleType GARSKKOLWYL(RHIZVYSCBOY a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5AB0", Offset = "0x8AD42B0", VA = "0x188AD5AB0", Slot = "12")]
		public bool LIEOBWOOYKD(RHIZVYSCBOY a, AccountRoleType b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8B70", Offset = "0x8AD7370", VA = "0x188AD8B70", Slot = "13")]
		public LDUVSNDRGQJ UHRUSKTNQOW(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5E00", Offset = "0x8AD4600", VA = "0x188AD5E00")]
		private static bool NESPYWLJLGP(FEBNAKZTOUQ a, AccountRoleType b, [Out] GTHGDLCZRLT? roleData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4580", Offset = "0x8AD2D80", VA = "0x188AD4580")]
		private static void ENPGLPJBCSP(FEBNAKZTOUQ a, Action<GTHGDLCZRLT> b, AccountRoleType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8AD42F0", Offset = "0x8AD2AF0", VA = "0x188AD42F0")]
		private static void ENPGLPJBCSP(FEBNAKZTOUQ a, Action<GTHGDLCZRLT> b, Predicate<AccountRoleType> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3EF0", Offset = "0x8AD26F0", VA = "0x188AD3EF0")]
		private void CAHGZHNMQVE(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6470", Offset = "0x8AD4C70", VA = "0x188AD6470", Slot = "4")]
		[AsyncStateMachine(typeof(<LEGACY_DeserializeFrom>d__32))]
		public Task NWWHPUUPOSA([CanBeNull] PersistedRoomData roomData, CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7340", Offset = "0x8AD5B40", VA = "0x188AD7340")]
		private void QHMWSDYKLRA(FEBNAKZTOUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8870", Offset = "0x8AD7070", VA = "0x188AD8870")]
		internal static string UDCDVCFEVKS(VIILDPRAETI a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, ILYAEWXMVBO> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7B90", Offset = "0x8AD6390", VA = "0x188AD7B90")]
		private static void TYXVAUUNJAQ(PersistedRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6130", Offset = "0x8AD4930", VA = "0x188AD6130")]
		private static void NVNVUNTLBOD(FEBNAKZTOUQ a, IReadOnlyDictionary<AccountRoleType, ILYAEWXMVBO> b, StringBuilder c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9410", Offset = "0x8AD7C10", VA = "0x188AD9410")]
		private static bool YWMWEIPTGJY(string a, [Out] Guid b, [Out] AccountRoleType c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6B30", Offset = "0x8AD5330", VA = "0x188AD6B30")]
		private static void PRWZINGYVHR(PersistedRoomData a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x33A4050", Offset = "0x33A2850", VA = "0x1833A4050", Slot = "14")]
		public bool GKGPDSWKWHI<T>(AccountRoleType a, RolePermission b, bool c, T d, [Optional] Action e) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5D90", Offset = "0x8AD4590", VA = "0x188AD5D90", Slot = "15")]
		public string MDSKPBYJIAC(RolePermission a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AD40E0", Offset = "0x8AD28E0", VA = "0x188AD40E0", Slot = "16")]
		public bool EBFBDXYIGZE(RHIZVYSCBOY a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5CD0", Offset = "0x8AD44D0", VA = "0x188AD5CD0", Slot = "18")]
		public bool MCTIVVUFWES(AccountRoleTypeNetworked a, RolePermission b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7710", Offset = "0x8AD5F10", VA = "0x188AD7710")]
		private void RUSGGCDCLTO(AccountRoleType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7250", Offset = "0x8AD5A50", VA = "0x188AD7250")]
		private bool PlayerHasRole(RHIZVYSCBOY player, AccountRoleType accountRoleType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD68A0", Offset = "0x8AD50A0", VA = "0x188AD68A0")]
		private ILYAEWXMVBO PJNTUKFZHUO(AccountRoleType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4FD0", Offset = "0x8AD37D0", VA = "0x188AD4FD0")]
		internal AccountRoleType IGAVEHOJEVQ(RHIZVYSCBOY a)
		{
			return default(AccountRoleType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3DB0", Offset = "0x8AD25B0", VA = "0x188AD3DB0")]
		private void ASJHCJZXXEY(int a, AccountRoleType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3F60", Offset = "0x8AD2760", VA = "0x188AD3F60", Slot = "11")]
		public IReadOnlyList<LDUVSNDRGQJ> PEPUDDZKLBR(RHIZVYSCBOY a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3F60", Offset = "0x8AD2760", VA = "0x188AD3F60")]
		internal IReadOnlyList<ILYAEWXMVBO> DAGURAMPILY(RHIZVYSCBOY a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6590", Offset = "0x8AD4D90", VA = "0x188AD6590")]
		internal IReadOnlyList<ILYAEWXMVBO> PDSFTWWDXFC(AccountRoleType a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4740", Offset = "0x8AD2F40", VA = "0x188AD4740")]
		private void HIMBIKFETVB(PhotonAccessTokenAndPermissionsDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9130", Offset = "0x8AD7930", VA = "0x188AD9130")]
		private static bool VVKZHNGHYQF(ILYAEWXMVBO a, IReadOnlyDictionary<AccountRoleType, ILYAEWXMVBO> b, [Out] IReadOnlyList<RolePermission> c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6760", Offset = "0x8AD4F60", VA = "0x188AD6760")]
		[AsyncStateMachine(typeof(<CoOwnerMigrateLegacyProtobufToRecNet>d__53))]
		private static Task PHEMNTGWLMR(VIILDPRAETI a, PersistedRoomData b, IReadOnlyDictionary<AccountRoleType, ILYAEWXMVBO> c, ZYRTIIHIZWB d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7910", Offset = "0x8AD6110", VA = "0x188AD7910")]
		[CompilerGenerated]
		internal static void TRYNPGTXQLU(Func<GTHGDLCZRLT, SHAIKNYIWKI> a, <>c__DisplayClass35_0 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8C10", Offset = "0x8AD7410", VA = "0x188AD8C10")]
		[CompilerGenerated]
		internal static bool UKBEOWSIPZX(AccountRoleType a, RolePermission b, [Out] RolePermissionDTO c, <>c__DisplayClass51_0 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface JTKDPWDVTAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool JEKIIJMMRCF(RHIZVYSCBOY a, RHIZVYSCBOY b, IEnumerable<RHIZVYSCBOY> c, [Out] VotekickType d, [Out] VotekickFailReason e);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string CHEDSWJYPMW(VotekickFailReason a);
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
	internal class ATBIJUOFSYZ : JTKDPWDVTAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly BULGXLLDMCM OQPZPGFDERB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly QMHTLMVZHQH XZGSUUIHDNH;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAA71B0", Offset = "0xAA59B0", VA = "0x180AA71B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ATBIJUOFSYZ([Inject(null)] BULGXLLDMCM roomRoleManager, [Inject(null)] QMHTLMVZHQH gameManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3380", Offset = "0x8AD1B80", VA = "0x188AD3380")]
		private static PlayerEvent? IOASOYBUBNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8AD33C0", Offset = "0x8AD1BC0", VA = "0x188AD33C0", Slot = "4")]
		public bool JEKIIJMMRCF(RHIZVYSCBOY a, RHIZVYSCBOY b, IEnumerable<RHIZVYSCBOY> c, [Out] VotekickType d, [Out] VotekickFailReason e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3280", Offset = "0x8AD1A80", VA = "0x188AD3280", Slot = "5")]
		public string CHEDSWJYPMW(VotekickFailReason a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD34C0", Offset = "0x8AD1CC0", VA = "0x188AD34C0")]
		internal bool SNPIKAZUWUI(RHIZVYSCBOY a, RHIZVYSCBOY b, IEnumerable<RHIZVYSCBOY> c, RoomDetailsDTO d, PlayerEvent? playerEvent, [Out] VotekickType e, [Out] VotekickFailReason f)
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
