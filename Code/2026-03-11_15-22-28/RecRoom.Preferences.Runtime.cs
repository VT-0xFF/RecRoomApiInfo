using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.UnityContainers;
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8886720", Offset = "0x8885720", VA = "0x188886720")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8883970", Offset = "0x8882970", VA = "0x188883970", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x888EBF0", Offset = "0x888DBF0", VA = "0x18888EBF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class KRHXLCTLBZJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(DADHGMUXDSN backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88837A0", Offset = "0x88827A0", VA = "0x1888837A0")]
		private static void UCYWKWEXGXG(DADHGMUXDSN a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8882FC0", Offset = "0x8881FC0", VA = "0x188882FC0")]
		public static bool DJJWGDBANUO(this DADHGMUXDSN a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8883820", Offset = "0x8882820", VA = "0x188883820")]
		public static SetResult YMLFPPPIRFL(this DADHGMUXDSN a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8883660", Offset = "0x8882660", VA = "0x188883660")]
		public static SetResult PLPFPVEHVLB(this DADHGMUXDSN a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8883120", Offset = "0x8882120", VA = "0x188883120")]
		public static SetResult GTYAXBZNPAE(this DADHGMUXDSN a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8883260", Offset = "0x8882260", VA = "0x188883260")]
		public static SetResult HOXNJUGMDGI(this DADHGMUXDSN a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88834F0", Offset = "0x88824F0", VA = "0x1888834F0")]
		public static SetResult PDJEAAMGHJT(this DADHGMUXDSN a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88833B0", Offset = "0x88823B0", VA = "0x1888833B0")]
		public static SetResult JIOLXNFOUGO(this DADHGMUXDSN a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OBGAAZWHJLY : LRAORDQVLJM, DADHGMUXDSN
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log RTTKRXBUKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly METPZPSIODF MLEVQWQATWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> UAGORCDPBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> QOARWGCNCST;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> LNDNOQQCESP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8888170", Offset = "0x8887170", VA = "0x188888170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8888BE0", Offset = "0x8887BE0", VA = "0x188888BE0")]
		[UnityEngine.Scripting.Preserve]
		public OBGAAZWHJLY([Inject(null)] METPZPSIODF unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88887C0", Offset = "0x88877C0", VA = "0x1888887C0")]
		private DirectoryInfo WNERXOMTLJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88875F0", Offset = "0x88865F0", VA = "0x1888875F0", Slot = "6")]
		public Task HHUWJBBGMJD(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8887580", Offset = "0x8886580", VA = "0x188887580", Slot = "14")]
		public float HCZFXGZJSSF(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8887F90", Offset = "0x8886F90", VA = "0x188887F90", Slot = "13")]
		public void NZDJGXRYQLH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88880B0", Offset = "0x88870B0", VA = "0x1888880B0", Slot = "12")]
		public bool PISYTSUFQVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8888990", Offset = "0x8887990", VA = "0x188888990", Slot = "10")]
		public int WSZZZPXMNLA(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88885E0", Offset = "0x88875E0", VA = "0x1888885E0", Slot = "18")]
		public DateTime UQEORCOAGYU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88888B0", Offset = "0x88878B0", VA = "0x1888888B0", Slot = "19")]
		public void WQWZDLBYOAQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8888A00", Offset = "0x8887A00", VA = "0x188888A00", Slot = "15")]
		public void YWTMENSIFNX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8887510", Offset = "0x8886510", VA = "0x188887510", Slot = "11")]
		public void GJTBBMNQTKW(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8887900", Offset = "0x8886900", VA = "0x188887900", Slot = "20")]
		public long MVDYXXUGCCD(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8888920", Offset = "0x8887920", VA = "0x188888920", Slot = "21")]
		public void WRIEFNQLCJB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x39442F0", Offset = "0x39432F0", VA = "0x1839442F0", Slot = "22")]
		public a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3942980", Offset = "0x3941980", VA = "0x183942980", Slot = "23")]
		public void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8888000", Offset = "0x8887000", VA = "0x188888000", Slot = "16")]
		public string OEPFZZEEFAI(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88881B0", Offset = "0x88871B0", VA = "0x1888881B0", Slot = "17")]
		public void QYKUZBTDTZC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8888650", Offset = "0x8887650", VA = "0x188888650", Slot = "24")]
		public void WCEKXFPXFRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8888220", Offset = "0x8887220", VA = "0x188888220", Slot = "9")]
		public bool RUNPLWMSTYQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88882B0", Offset = "0x88872B0", VA = "0x1888882B0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8887970", Offset = "0x8886970", VA = "0x188887970")]
		private void NTSUQGLHIGL(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88876E0", Offset = "0x88866E0", VA = "0x1888876E0")]
		private static string KXKXAPYHQVU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8888A70", Offset = "0x8887A70", VA = "0x188888A70")]
		private static string ZYYKGOHASQX(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3942B20", Offset = "0x3941B20", VA = "0x183942B20")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] SAUETGUVVDZ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x39444D0", Offset = "0x39434D0", VA = "0x1839444D0")]
		private void Set<T>(string propertyName, T value, [Optional] SAUETGUVVDZ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88867A0", Offset = "0x88857A0", VA = "0x1888867A0")]
		private Dictionary<string, string> BRRAFURWYHV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8887680", Offset = "0x8886680", VA = "0x188887680")]
		private void IQLLUARCGYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88874A0", Offset = "0x88864A0", VA = "0x1888874A0")]
		private void DYVYABFXDEA(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class FEQKOREIPMU
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log RTTKRXBUKRF;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8882270", Offset = "0x8881270", VA = "0x188882270")]
		[WUCJGMLKEDZ.Root]
		internal static void WUCJGMLKEDZ(KTJKRWFMICD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IHULETNBEEB : UMJSIUZFMQA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8882F40", Offset = "0x8881F40", VA = "0x188882F40")]
		[UnityEngine.Scripting.Preserve]
		public IHULETNBEEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FMLXKBMWJGB : LRAORDQVLJM, DADHGMUXDSN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly METPZPSIODF MLEVQWQATWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> QPZGOYMGBMX;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8882C10", Offset = "0x8881C10", VA = "0x188882C10")]
		[UnityEngine.Scripting.Preserve]
		public FMLXKBMWJGB([Inject(null)] METPZPSIODF unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8882590", Offset = "0x8881590", VA = "0x188882590", Slot = "6")]
		public Task HHUWJBBGMJD(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8882860", Offset = "0x8881860", VA = "0x188882860", Slot = "9")]
		public bool RUNPLWMSTYQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8882B30", Offset = "0x8881B30", VA = "0x188882B30", Slot = "10")]
		public int WSZZZPXMNLA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88824B0", Offset = "0x88814B0", VA = "0x1888824B0", Slot = "11")]
		public void GJTBBMNQTKW(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8882780", Offset = "0x8881780", VA = "0x188882780", Slot = "12")]
		public bool PISYTSUFQVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8882690", Offset = "0x8881690", VA = "0x188882690", Slot = "13")]
		public void NZDJGXRYQLH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8882520", Offset = "0x8881520", VA = "0x188882520", Slot = "14")]
		public float HCZFXGZJSSF(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8882BA0", Offset = "0x8881BA0", VA = "0x188882BA0", Slot = "15")]
		public void YWTMENSIFNX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8882700", Offset = "0x8881700", VA = "0x188882700", Slot = "16")]
		public string OEPFZZEEFAI(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88827F0", Offset = "0x88817F0", VA = "0x1888827F0", Slot = "17")]
		public void QYKUZBTDTZC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8882950", Offset = "0x8881950", VA = "0x188882950", Slot = "18")]
		public DateTime UQEORCOAGYU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8882A50", Offset = "0x8881A50", VA = "0x188882A50", Slot = "19")]
		public void WQWZDLBYOAQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8882620", Offset = "0x8881620", VA = "0x188882620", Slot = "20")]
		public long MVDYXXUGCCD(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8882AC0", Offset = "0x8881AC0", VA = "0x188882AC0", Slot = "21")]
		public void WRIEFNQLCJB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37334C0", Offset = "0x37324C0", VA = "0x1837334C0", Slot = "22")]
		public a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3731A30", Offset = "0x3730A30", VA = "0x183731A30", Slot = "23")]
		public void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88829C0", Offset = "0x88819C0", VA = "0x1888829C0", Slot = "24")]
		public void WCEKXFPXFRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88828C0", Offset = "0x88818C0", VA = "0x1888828C0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3731BD0", Offset = "0x3730BD0", VA = "0x183731BD0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] SAUETGUVVDZ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37336A0", Offset = "0x37326A0", VA = "0x1837336A0")]
		private void Set<T>(string propertyName, T value, [Optional] SAUETGUVVDZ<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UMJSIUZFMQA : LRAORDQVLJM, DADHGMUXDSN, WFTPEKSCRIY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> ASLITJJKYUI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x888E5A0", Offset = "0x888D5A0", VA = "0x18888E5A0", Slot = "6")]
		public Task HHUWJBBGMJD(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x888E810", Offset = "0x888D810", VA = "0x18888E810", Slot = "9")]
		public bool RUNPLWMSTYQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x888EA80", Offset = "0x888DA80", VA = "0x18888EA80", Slot = "10")]
		public int WSZZZPXMNLA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x888E4E0", Offset = "0x888D4E0", VA = "0x18888E4E0", Slot = "11")]
		public void GJTBBMNQTKW(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x888E750", Offset = "0x888D750", VA = "0x18888E750", Slot = "12")]
		public bool PISYTSUFQVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x888E690", Offset = "0x888D690", VA = "0x18888E690", Slot = "13")]
		public void NZDJGXRYQLH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x888E540", Offset = "0x888D540", VA = "0x18888E540", Slot = "14")]
		public float HCZFXGZJSSF(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x888EAE0", Offset = "0x888DAE0", VA = "0x18888EAE0", Slot = "15")]
		public void YWTMENSIFNX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x888E6F0", Offset = "0x888D6F0", VA = "0x18888E6F0", Slot = "16")]
		public string OEPFZZEEFAI(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x888E7B0", Offset = "0x888D7B0", VA = "0x18888E7B0", Slot = "17")]
		public void QYKUZBTDTZC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x888E900", Offset = "0x888D900", VA = "0x18888E900", Slot = "18")]
		public DateTime UQEORCOAGYU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x888E9C0", Offset = "0x888D9C0", VA = "0x18888E9C0", Slot = "19")]
		public void WQWZDLBYOAQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x888E630", Offset = "0x888D630", VA = "0x18888E630", Slot = "20")]
		public long MVDYXXUGCCD(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x888EA20", Offset = "0x888DA20", VA = "0x18888EA20", Slot = "21")]
		public void WRIEFNQLCJB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DD90", Offset = "0x3C0CD90", VA = "0x183C0DD90", Slot = "22")]
		public a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D020", Offset = "0x3C0C020", VA = "0x183C0D020", Slot = "23")]
		public void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D220", Offset = "0x3C0C220", VA = "0x183C0D220")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E140", Offset = "0x3C0D140", VA = "0x183C0E140")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x888E960", Offset = "0x888D960", VA = "0x18888E960", Slot = "24")]
		public void WCEKXFPXFRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x888E870", Offset = "0x888D870", VA = "0x18888E870", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8882F40", Offset = "0x8881F40", VA = "0x188882F40")]
		public UMJSIUZFMQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class FOLPHHCXTQL<a> where a : DADHGMUXDSN
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<FOLPHHCXTQL<a>> CAOXYCZHACM;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4F12000", Offset = "0x4F11000", VA = "0x184F12000")]
		protected FOLPHHCXTQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void ELVPFRIRSLR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4F113B0", Offset = "0x4F103B0", VA = "0x184F113B0")]
		public static void RKBHRKBBLLV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4F11B40", Offset = "0x4F10B40", VA = "0x184F11B40")]
		public static void XWINHXCHIID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FOQWENWVDBU<a, b> : FOLPHHCXTQL<a> where a : DADHGMUXDSN
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly FOQWENWVDBU<a, b> GOGYEQDLKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> SZQBAOOFIRB;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4F123D0", Offset = "0x4F113D0", VA = "0x184F123D0")]
		public bool DVVDXLGNEBL(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4F126A0", Offset = "0x4F116A0", VA = "0x184F126A0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
		public IEnumerable<KeyValuePair<string, b>> BTTCGBHNOPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3F05B20", Offset = "0x3F04B20", VA = "0x183F05B20", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4F12490", Offset = "0x4F11490", VA = "0x184F12490", Slot = "5")]
		protected override void ELVPFRIRSLR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4F12AE0", Offset = "0x4F11AE0", VA = "0x184F12AE0")]
		public FOQWENWVDBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DADHGMUXDSN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TXNXETCVXKR();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool RUNPLWMSTYQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int WSZZZPXMNLA(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GJTBBMNQTKW(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PISYTSUFQVX(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NZDJGXRYQLH(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float HCZFXGZJSSF(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YWTMENSIFNX(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string OEPFZZEEFAI(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QYKUZBTDTZC(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime UQEORCOAGYU(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WQWZDLBYOAQ(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long MVDYXXUGCCD(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void WRIEFNQLCJB(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void WCEKXFPXFRN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface LRAORDQVLJM : DADHGMUXDSN
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action JAUNQEKMJTD;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task HHUWJBBGMJD(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface WFTPEKSCRIY : DADHGMUXDSN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class MVNNXLWGXIW : LRAORDQVLJM, DADHGMUXDSN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <Save>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public MVNNXLWGXIW <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x888D6C0", Offset = "0x888C6C0", VA = "0x18888D6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x888DA80", Offset = "0x888CA80", VA = "0x18888DA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class ZNOFWBFHTSO : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public MVNNXLWGXIW SULNKEFFSGR;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public ZNOFWBFHTSO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x888EB40", Offset = "0x888DB40", VA = "0x18888EB40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x888EBB0", Offset = "0x888DBB0", VA = "0x18888EBB0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log RTTKRXBUKRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly METPZPSIODF MLEVQWQATWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool KKTUPVHAZRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NGZLSPECZWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private GUCSXSLGSZF JNSPOQFQAOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ALZORZCQSFK CJJVQXANIXM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8886620", Offset = "0x8885620", VA = "0x188886620")]
		[UnityEngine.Scripting.Preserve]
		public MVNNXLWGXIW([Inject(null)] METPZPSIODF unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88856F0", Offset = "0x88846F0", VA = "0x1888856F0", Slot = "6")]
		public Task HHUWJBBGMJD(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1C165F0", Offset = "0x1C155F0", VA = "0x181C165F0")]
		private static int QLUDSCMOBST(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8885EA0", Offset = "0x8884EA0", VA = "0x188885EA0", Slot = "9")]
		public bool RUNPLWMSTYQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8886190", Offset = "0x8885190", VA = "0x188886190", Slot = "10")]
		public int WSZZZPXMNLA(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8885510", Offset = "0x8884510", VA = "0x188885510", Slot = "11")]
		public void GJTBBMNQTKW(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8885C20", Offset = "0x8884C20", VA = "0x188885C20", Slot = "12")]
		public bool PISYTSUFQVX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8885920", Offset = "0x8884920", VA = "0x188885920", Slot = "13")]
		public void NZDJGXRYQLH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x88855C0", Offset = "0x88845C0", VA = "0x1888855C0", Slot = "14")]
		public float HCZFXGZJSSF(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8886350", Offset = "0x8885350", VA = "0x188886350", Slot = "15")]
		public void YWTMENSIFNX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8885FB0", Offset = "0x8884FB0", VA = "0x188885FB0", Slot = "18")]
		public DateTime UQEORCOAGYU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x88860B0", Offset = "0x88850B0", VA = "0x1888860B0", Slot = "19")]
		public void WQWZDLBYOAQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88858B0", Offset = "0x88848B0", VA = "0x1888858B0", Slot = "20")]
		public long MVDYXXUGCCD(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8886120", Offset = "0x8885120", VA = "0x188886120", Slot = "21")]
		public void WRIEFNQLCJB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3858750", Offset = "0x3857750", VA = "0x183858750", Slot = "22")]
		public a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3858450", Offset = "0x3857450", VA = "0x183858450", Slot = "23")]
		public void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3859490", Offset = "0x3858490", VA = "0x183859490")]
		private c UMUBUKFMRSH<c>(string a, c b, [Optional] SAUETGUVVDZ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3858950", Offset = "0x3857950", VA = "0x183858950")]
		private void RBSEOJFANNV<d>(string a, d b, [Optional] SAUETGUVVDZ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8885A70", Offset = "0x8884A70", VA = "0x188885A70", Slot = "16")]
		public string OEPFZZEEFAI(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8885D70", Offset = "0x8884D70", VA = "0x188885D70", Slot = "17")]
		public void QYKUZBTDTZC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x88853F0", Offset = "0x88843F0", VA = "0x1888853F0")]
		private void EVJIJUKTLTP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8886410", Offset = "0x8885410", VA = "0x188886410")]
		private string ZKSFBWISIIF(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8886020", Offset = "0x8885020", VA = "0x188886020", Slot = "24")]
		public void WCEKXFPXFRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x88862B0", Offset = "0x88852B0", VA = "0x1888862B0")]
		private string XMOVWKJIUED(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8883AE0", Offset = "0x8882AE0", VA = "0x188883AE0")]
		public void ERWHKHBBOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8885850", Offset = "0x8884850", VA = "0x188885850", Slot = "26")]
		public void LXOWOVPGVAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8885EC0", Offset = "0x8884EC0", VA = "0x188885EC0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8885A00", Offset = "0x8884A00", VA = "0x188885A00")]
		[IteratorStateMachine(typeof(ZNOFWBFHTSO))]
		private IEnumerator<ADJUPIXYSVF> ODZVKHCEVGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x88857F0", Offset = "0x88847F0", VA = "0x1888857F0")]
		private void JEIMJRUKKFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8885780", Offset = "0x8884780", VA = "0x188885780")]
		private void IQLLUARCGYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8883A70", Offset = "0x8882A70", VA = "0x188883A70")]
		private void DYVYABFXDEA(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class OOCRAQBIDBW : LRAORDQVLJM, DADHGMUXDSN
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<string, string> QOARWGCNCST;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string WEUPJCXUSLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x88894D0", Offset = "0x88884D0", VA = "0x1888894D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string VXRRZXJFYRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x8889340", Offset = "0x8888340", VA = "0x188889340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> LNDNOQQCESP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8889490", Offset = "0x8888490", VA = "0x188889490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		[UnityEngine.Scripting.Preserve]
		public OOCRAQBIDBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "8")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8889120", Offset = "0x8888120", VA = "0x188889120", Slot = "6")]
		public Task HHUWJBBGMJD(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x88890B0", Offset = "0x88880B0", VA = "0x1888890B0", Slot = "14")]
		public float HCZFXGZJSSF(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8889220", Offset = "0x8888220", VA = "0x188889220", Slot = "13")]
		public void NZDJGXRYQLH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x88893D0", Offset = "0x88883D0", VA = "0x1888893D0", Slot = "12")]
		public bool PISYTSUFQVX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8889B00", Offset = "0x8888B00", VA = "0x188889B00", Slot = "10")]
		public int WSZZZPXMNLA(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x88898F0", Offset = "0x88888F0", VA = "0x1888898F0", Slot = "18")]
		public DateTime UQEORCOAGYU(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8889A20", Offset = "0x8888A20", VA = "0x188889A20", Slot = "19")]
		public void WQWZDLBYOAQ(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8889B70", Offset = "0x8888B70", VA = "0x188889B70", Slot = "15")]
		public void YWTMENSIFNX(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8889040", Offset = "0x8888040", VA = "0x188889040", Slot = "11")]
		public void GJTBBMNQTKW(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x88891B0", Offset = "0x88881B0", VA = "0x1888891B0", Slot = "20")]
		public long MVDYXXUGCCD(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8889A90", Offset = "0x8888A90", VA = "0x188889A90", Slot = "21")]
		public void WRIEFNQLCJB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3964290", Offset = "0x3963290", VA = "0x183964290", Slot = "22")]
		public a JRTYDSUQSDE<a>(string a, a b, SAUETGUVVDZ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3962920", Offset = "0x3961920", VA = "0x183962920", Slot = "23")]
		public void CCBXPUVRBPE<b>(string a, b b, SAUETGUVVDZ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8889290", Offset = "0x8888290", VA = "0x188889290", Slot = "16")]
		public string OEPFZZEEFAI(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8889560", Offset = "0x8888560", VA = "0x188889560", Slot = "17")]
		public void QYKUZBTDTZC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8889960", Offset = "0x8888960", VA = "0x188889960", Slot = "24")]
		public void WCEKXFPXFRN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8889600", Offset = "0x8888600", VA = "0x188889600", Slot = "9")]
		public bool RUNPLWMSTYQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8889690", Offset = "0x8888690", VA = "0x188889690", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3962AC0", Offset = "0x3961AC0", VA = "0x183962AC0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] SAUETGUVVDZ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3964470", Offset = "0x3963470", VA = "0x183964470")]
		private void Set<T>(string propertyName, T value, [Optional] SAUETGUVVDZ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8888D30", Offset = "0x8887D30", VA = "0x188888D30")]
		private Dictionary<string, string> BRRAFURWYHV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface YWYQZTWAWYA
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action JAUNQEKMJTD;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TXNXETCVXKR();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task PUROKCSJJAL(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool QHLIFHWJCVN(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ORRXQILDVBF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NOXVUYCFIGO(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string KIWMFVGVDTH(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult HMNWCWCZMUV(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int POUEHBCTLRT(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult QOYQVPPIEMV(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool VYWVTIGTFQU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult HKIILQNMFNW(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float QFQJVDNAFTI(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult VMSMEXXMLBQ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime TERQZRDXSKB(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult CBWUBDFVOFX(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long BCCMXVRFLYK(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult TDTHBMPPELM(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a ELNCEVTOWRR<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult AZEDGJIFSGL<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool PNCMLAJVPIX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool MLBLLKJOEYU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string IBYPYZKWEUB(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult YNRAKQHEXTL(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int LQCXGKLPDTP(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult THJMYOKHAFD(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool YEXBTMSMNWQ(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult GFFTMPJSPCM(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float GYFOAZFMHVM(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult VJMQINHFTJI(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime NGFDJBUPTGV(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult CXMTSLSCCRH(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long TDKQILGGSNU(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult ZIDBUVZAFOC(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void OLEHCRQBWUB<e>(SAUETGUVVDZ<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void VKQVNEKIQLM<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable GZPCXFPGXLZ();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void UTOXMRWPLIA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task JEIMJRUKKFZ([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Preferences : YWYQZTWAWYA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class FTIAHIIBEDY
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<FTIAHIIBEDY> SATZNACCSRD;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8882CB0", Offset = "0x8881CB0", VA = "0x188882CB0")]
			public static void XWINHXCHIID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			protected FTIAHIIBEDY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class SMKOAIYGMBX<a> : FTIAHIIBEDY
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly SMKOAIYGMBX<a> QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public SAUETGUVVDZ<a> LLPQOEDRUMI
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> PRCLBJFGXDW
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool EBQXJZPTZAD
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xC6C9F0", Offset = "0xC6B9F0", VA = "0x180C6C9F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x60E1B20", Offset = "0x60E0B20", VA = "0x1860E1B20")]
			private SMKOAIYGMBX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x60E0FF0", Offset = "0x60DFFF0", VA = "0x1860E0FF0")]
			public void BPSMAKIBARY(SAUETGUVVDZ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xDC7100", Offset = "0xDC6100", VA = "0x180DC7100", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class QEYTJMLLQQS : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences WEEOQGMLEGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object DZTYVXXMDYJ;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x888CDA0", Offset = "0x888BDA0", VA = "0x18888CDA0")]
			public QEYTJMLLQQS(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x888CD70", Offset = "0x888BD70", VA = "0x18888CD70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x888CE50", Offset = "0x888BE50", VA = "0x18888CE50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x888D130", Offset = "0x888C130", VA = "0x18888D130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public DADHGMUXDSN backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x888DAE0", Offset = "0x888CAE0", VA = "0x18888DAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x888D190", Offset = "0x888C190", VA = "0x18888D190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x888D660", Offset = "0x888C660", VA = "0x18888D660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GHVVAGLQHCQ : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float WYDQDVOOSWQ;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public GHVVAGLQHCQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8882E70", Offset = "0x8881E70", VA = "0x188882E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8882F00", Offset = "0x8881F00", VA = "0x188882F00", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly LRAORDQVLJM FHQRMATBBFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LRAORDQVLJM DDQPZMZTSGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly WFTPEKSCRIY AWONEYBLVYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly GUCSXSLGSZF JNSPOQFQAOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly KRHXLCTLBZJ.CustomSaveHandler GQLYRLGSIFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly UOYNNJIMGKD JZQXVOERFGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<DADHGMUXDSN> XTLOOXNNFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task ZHMLXXNLSDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> ZEKKQLCQIHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private ALZORZCQSFK LZMVZTIXRPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object TWLAUFBJAWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object KTXIBHPEKEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long MGIQKCHKEYJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool GLULDZXTBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x17F1EB0", Offset = "0x17F0EB0", VA = "0x1817F1EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource OJSFJVOCTZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xACDF50", Offset = "0xACCF50", VA = "0x180ACDF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action JAUNQEKMJTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x888A720", Offset = "0x8889720", VA = "0x18888A720", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x888A8B0", Offset = "0x88898B0", VA = "0x18888A8B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x888AF80", Offset = "0x8889F80", VA = "0x18888AF80")]
		[WUCJGMLKEDZ.Root]
		internal static void MTTBWJSTHKM(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x888C9E0", Offset = "0x888B9E0", VA = "0x18888C9E0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] LRAORDQVLJM localBackingStore, [Inject("Cloud")] LRAORDQVLJM cloudBackingStore, [Inject(null)] WFTPEKSCRIY editorBackingStore, [Inject(null)] GUCSXSLGSZF scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8889FF0", Offset = "0x8888FF0", VA = "0x188889FF0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8889FA0", Offset = "0x8888FA0", VA = "0x188889FA0")]
		private void DRMLUUXVNID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x888BF70", Offset = "0x888AF70", VA = "0x18888BF70", Slot = "6")]
		public void TXNXETCVXKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x888B390", Offset = "0x888A390", VA = "0x18888B390", Slot = "7")]
		public Task PUROKCSJJAL(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x888C8A0", Offset = "0x888B8A0", VA = "0x18888C8A0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task YOXZLUZDKPC(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x888AEF0", Offset = "0x8889EF0", VA = "0x18888AEF0")]
		private void MGDZWZFVJCF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x888A060", Offset = "0x8889060", VA = "0x18888A060")]
		private void GIVOZZZOCQI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x888C340", Offset = "0x888B340", VA = "0x18888C340")]
		private string VPKLFFAWYVN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x888C020", Offset = "0x888B020", VA = "0x18888C020")]
		private void VMEQXYKULFF(AccountPreferenceBackingStoreTypes a, string b, [Out] LRAORDQVLJM c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x888BAE0", Offset = "0x888AAE0", VA = "0x18888BAE0")]
		private LRAORDQVLJM RUBBAZLGYFB(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x888B610", Offset = "0x888A610", VA = "0x18888B610", Slot = "8")]
		public bool QHLIFHWJCVN(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x888B1E0", Offset = "0x888A1E0", VA = "0x18888B1E0", Slot = "9")]
		public bool ORRXQILDVBF(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x888B060", Offset = "0x888A060", VA = "0x18888B060", Slot = "10")]
		public bool NOXVUYCFIGO(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x888AA90", Offset = "0x8889A90", VA = "0x18888AA90", Slot = "11")]
		public string KIWMFVGVDTH(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x888A520", Offset = "0x8889520", VA = "0x18888A520", Slot = "12")]
		public SetResult HMNWCWCZMUV(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x888B2E0", Offset = "0x888A2E0", VA = "0x18888B2E0", Slot = "13")]
		public int POUEHBCTLRT(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x888B800", Offset = "0x888A800", VA = "0x18888B800", Slot = "14")]
		public SetResult QOYQVPPIEMV(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x888C4E0", Offset = "0x888B4E0", VA = "0x18888C4E0", Slot = "15")]
		public bool VYWVTIGTFQU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x888A3A0", Offset = "0x88893A0", VA = "0x18888A3A0", Slot = "16")]
		public SetResult HKIILQNMFNW(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x888B560", Offset = "0x888A560", VA = "0x18888B560", Slot = "17")]
		public float QFQJVDNAFTI(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x888C1C0", Offset = "0x888B1C0", VA = "0x18888C1C0", Slot = "18")]
		public SetResult VMSMEXXMLBQ(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x888BEA0", Offset = "0x888AEA0", VA = "0x18888BEA0", Slot = "19")]
		public DateTime TERQZRDXSKB(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8889C80", Offset = "0x8888C80", VA = "0x188889C80", Slot = "20")]
		public SetResult CBWUBDFVOFX(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8889BE0", Offset = "0x8888BE0", VA = "0x188889BE0", Slot = "21")]
		public long BCCMXVRFLYK(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x888BD20", Offset = "0x888AD20", VA = "0x18888BD20", Slot = "22")]
		public SetResult TDTHBMPPELM(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x39953C0", Offset = "0x39943C0", VA = "0x1839953C0", Slot = "23")]
		public a ELNCEVTOWRR<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3995020", Offset = "0x3994020", VA = "0x183995020", Slot = "24")]
		public SetResult AZEDGJIFSGL<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x888B280", Offset = "0x888A280", VA = "0x18888B280", Slot = "25")]
		public bool PNCMLAJVPIX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x888AF70", Offset = "0x8889F70", VA = "0x18888AF70", Slot = "26")]
		public bool MLBLLKJOEYU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x888A6B0", Offset = "0x88896B0", VA = "0x18888A6B0", Slot = "27")]
		public string IBYPYZKWEUB(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x888C870", Offset = "0x888B870", VA = "0x18888C870", Slot = "28")]
		public SetResult YNRAKQHEXTL(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x888AE80", Offset = "0x8889E80", VA = "0x18888AE80", Slot = "29")]
		public int LQCXGKLPDTP(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x888BF40", Offset = "0x888AF40", VA = "0x18888BF40", Slot = "30")]
		public SetResult THJMYOKHAFD(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x888C800", Offset = "0x888B800", VA = "0x18888C800", Slot = "31")]
		public bool YEXBTMSMNWQ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x888A030", Offset = "0x8889030", VA = "0x18888A030", Slot = "32")]
		public SetResult GFFTMPJSPCM(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x888A0E0", Offset = "0x88890E0", VA = "0x18888A0E0", Slot = "33")]
		public float GYFOAZFMHVM(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x888BFF0", Offset = "0x888AFF0", VA = "0x18888BFF0", Slot = "34")]
		public SetResult VJMQINHFTJI(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x888AFF0", Offset = "0x8889FF0", VA = "0x18888AFF0", Slot = "35")]
		public DateTime NGFDJBUPTGV(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8889E20", Offset = "0x8888E20", VA = "0x188889E20", Slot = "36")]
		public SetResult CXMTSLSCCRH(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x888BCB0", Offset = "0x888ACB0", VA = "0x18888BCB0", Slot = "37")]
		public long TDKQILGGSNU(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x888C9B0", Offset = "0x888B9B0", VA = "0x18888C9B0", Slot = "38")]
		public SetResult ZIDBUVZAFOC(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x888AF10", Offset = "0x8889F10", VA = "0x18888AF10")]
		private bool MIZPDXPMXVH(DADHGMUXDSN a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x888B980", Offset = "0x888A980", VA = "0x18888B980")]
		private bool RFAKHGGRSQE(DADHGMUXDSN a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x888A220", Offset = "0x8889220", VA = "0x18888A220")]
		private SetResult HBIQUZBLEQQ(DADHGMUXDSN a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x888A950", Offset = "0x8889950", VA = "0x18888A950")]
		private SetResult JMURJGCJIQW(DADHGMUXDSN a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x888C3A0", Offset = "0x888B3A0", VA = "0x18888C3A0")]
		private SetResult VTEYARLXDRH(DADHGMUXDSN a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8889E50", Offset = "0x8888E50", VA = "0x188889E50")]
		private SetResult DHECLAJKJKF(DADHGMUXDSN a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x888AB30", Offset = "0x8889B30", VA = "0x18888AB30")]
		private SetResult KMFHTMVWLVC(DADHGMUXDSN a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x888B6C0", Offset = "0x888A6C0", VA = "0x18888B6C0")]
		private SetResult QKQBWYKWEJJ(DADHGMUXDSN a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3996D20", Offset = "0x3995D20", VA = "0x183996D20")]
		private e SFZKWXIFTLI<e>(DADHGMUXDSN a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3995EA0", Offset = "0x3994EA0", VA = "0x183995EA0")]
		private SetResult ISCJPLSQTQC<f>(DADHGMUXDSN a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3996930", Offset = "0x3995930", VA = "0x183996930", Slot = "39")]
		public void OLEHCRQBWUB<g>(SAUETGUVVDZ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x39971C0", Offset = "0x39961C0", VA = "0x1839971C0", Slot = "40")]
		public void VKQVNEKIQLM<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x888BB60", Offset = "0x888AB60", VA = "0x18888BB60")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(DADHGMUXDSN backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x888A7C0", Offset = "0x88897C0", VA = "0x18888A7C0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task JEIMJRUKKFZ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x888ACA0", Offset = "0x8889CA0", VA = "0x18888ACA0")]
		private void LPFUVCTRTTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x888A150", Offset = "0x8889150", VA = "0x18888A150", Slot = "41")]
		public IDisposable GZPCXFPGXLZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x888BFE0", Offset = "0x888AFE0", VA = "0x18888BFE0", Slot = "42")]
		public void UTOXMRWPLIA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x888C590", Offset = "0x888B590", VA = "0x18888C590")]
		private void WGPRTWWMVPW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x888BC30", Offset = "0x888AC30", VA = "0x18888BC30")]
		[IteratorStateMachine(typeof(GHVVAGLQHCQ))]
		private IEnumerator<ADJUPIXYSVF> TAPPJUUBCKO(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x888A370", Offset = "0x8889370", VA = "0x18888A370")]
		[CompilerGenerated]
		private void HCPZKSSRUHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class AZIKYIAPHWW
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8881B60", Offset = "0x8880B60", VA = "0x188881B60")]
		public static string DKHQQEIPGEV(this YWYQZTWAWYA a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x88819C0", Offset = "0x88809C0", VA = "0x1888819C0")]
		public static byte[] BNXDJTGEUVZ(this YWYQZTWAWYA a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8881CD0", Offset = "0x8880CD0", VA = "0x188881CD0")]
		public static SetResult WNRYMIBEPHV(this YWYQZTWAWYA a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class EIKICQITBXF : FGOWNLCBRIP<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static EIKICQITBXF QSHZKWMVMOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8881DE0", Offset = "0x8880DE0", VA = "0x188881DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8881E30", Offset = "0x8880E30", VA = "0x188881E30", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8881F20", Offset = "0x8880F20", VA = "0x188881F20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8882230", Offset = "0x8881230", VA = "0x188882230")]
		public EIKICQITBXF()
		{
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
